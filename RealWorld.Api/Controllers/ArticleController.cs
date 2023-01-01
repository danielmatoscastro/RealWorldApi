using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RealWorld.Api.DTOs;
using RealWorld.Api.Extensions;
using RealWorld.Api.Models;
using RealWorld.Api.Services.Abstraction;
using RealWorld.Api.ViewModels;

namespace RealWorld.Api.Controllers;

[ApiController]
[Route("api/articles")]
public class ArticleController : ControllerBase
{
    private readonly IUserService _userService;
    private readonly IArticleService _articleService;
    
    public ArticleController(IUserService userService, IArticleService articleService)
    {
        _userService = userService;
        _articleService = articleService;
    }

    [HttpGet]
    public async Task<IActionResult> GetArticlesAsync([FromQuery] ArticleSearchParamsDTO searchParams)
    {
        var loggedUser = await _userService.GetLoggedUserAsync(User.GetLoggedUserId());
        var articles = await _articleService.GetArticlesAsync(searchParams);

        var articlesResponse = MapArticlesToViewModels(loggedUser, articles);
        return Ok(new
        {
            Articles = articlesResponse,
            ArticlesCount = articlesResponse.Count(),
        });
    }

    [Authorize]
    [HttpGet("feed")]
    public async Task<IActionResult> GetFeedArticlesAsync([FromQuery] int limit = 20, [FromQuery] int offset = 0)
    {
        var loggedUser = await _userService.GetLoggedUserAsync(User.GetLoggedUserId());
        if (loggedUser == null)
        {
            return Unauthorized();
        }

        var articles = await _articleService.GetFeedArticlesAsync(loggedUser, limit, offset);

        var articlesResponse = MapArticlesToViewModels(loggedUser, articles);
        return Ok(new
        {
            Articles = articlesResponse,
            ArticlesCount = articlesResponse.Count(),
        });
    }

    [HttpGet("{slug}")]
    public async Task<IActionResult> GetArticleBySlugAsync([FromRoute] string slug)
    {
        var loggedUser = await _userService.GetLoggedUserAsync(User.GetLoggedUserId());
        var article = await _articleService.GetArticleBySlugAsync(slug);
        if (article == null)
        {
            return NotFound();
        }

        var articleResponse = MapArticleToViewModel(loggedUser, article);
        return Ok(new
        {
            Article = articleResponse
        });
    }

    [Authorize]
    [HttpPost]
    public async Task<IActionResult> CreateArticleAsync([FromBody] CreateArticleViewModel payload)
    {
        if (!ModelState.IsValid)
        {
            return UnprocessableEntity(ModelState.ToErrorsResponseViewModel());
        }

        var loggedUser = await _userService.GetLoggedUserAsync(User.GetLoggedUserId());
        if (loggedUser == null)
        {
            return Unauthorized();
        }

        var tagsModels = MapTagListToTagsModels(payload.Article.TagList);
        
        var articleModel = await _articleService.CreateArticleAsync(
            loggedUser, 
            payload.Article.Body, 
            payload.Article.Description, 
            payload.Article.Title, 
            tagsModels);

        var articleResponse = MapArticleToViewModel(loggedUser, articleModel);
        return Ok(new
        {
            Article = articleResponse
        });
    }

    [HttpPatch("{slug}")]
    public async Task<IActionResult> UpdateArticle([FromRoute] string slug, [FromBody] UpdateArticleViewModel payload)
    {
        if (!ModelState.IsValid)
        {
            return UnprocessableEntity(ModelState.ToErrorsResponseViewModel());
        }

        var loggedUser = await _userService.GetLoggedUserAsync(User.GetLoggedUserId());
        if (loggedUser == null)
        {
            return Unauthorized();
        }
        
        var articleModel = await _articleService.UpdateArticleAsync(
            loggedUser, 
            slug, 
            payload.Article.Title,
            payload.Article.Description, 
            payload.Article.Body);

        var articleResponse = MapArticleToViewModel(loggedUser, articleModel);
        return Ok(new
        {
            Article = articleResponse
        });
    }

    [Authorize]
    [HttpDelete("{slug}")]
    public async Task<IActionResult> DeleteArticle([FromRoute] string slug)
    {
        var loggedUser = await _userService.GetLoggedUserAsync(User.GetLoggedUserId());
        if (loggedUser == null)
        {
            return Unauthorized();
        }

        await _articleService.DeleteArticleAsync(loggedUser, slug);

        return NoContent();
    }

    [Authorize]
    [HttpPost("{slug}/comments")]
    public async Task<IActionResult> AddCommentToArticle([FromRoute] string slug, [FromBody] AddCommentViewModel payload)
    {
        if (!ModelState.IsValid)
        {
            return UnprocessableEntity(ModelState.ToErrorsResponseViewModel());
        }

        var loggedUser = await _userService.GetLoggedUserAsync(User.GetLoggedUserId());
        if (loggedUser == null)
        {
            return Unauthorized();
        }

        var comment = await _articleService.AddCommentToArticleAsync(loggedUser, slug, payload.Comment.Body);
        
        var response = MapCommentToViewModel(loggedUser, comment);

        return Ok(new
        {
            Comment = response
        });
    }

    [HttpGet("{slug}/comments")]
    public async Task<IActionResult> GetAllComments([FromRoute] string slug)
    {
        var loggedUser = await _userService.GetLoggedUserAsync(User.GetLoggedUserId());

        var comments = await _articleService.GetCommentsBySlugAsync(slug);

        return Ok(new
        {
            Comments = MapCommentsToViewModels(loggedUser, comments),
        });
    }

    [Authorize]
    [HttpDelete("{slug}/comments/{id:int}")]
    public async Task<IActionResult> DeleteComment([FromRoute] string slug, [FromRoute] int id)
    {
        var loggedUser = await _userService.GetLoggedUserAsync(User.GetLoggedUserId());
        if (loggedUser == null)
        {
            return Unauthorized();
        }

        await _articleService.DeleteCommentAsync(loggedUser, slug, id);

        return NoContent();
    }

    [Authorize]
    [HttpPost("{slug}/favorite")]
    public async Task<IActionResult> FavoriteArticle([FromRoute] string slug)
    {
        var loggedUser = await _userService.GetLoggedUserAsync(User.GetLoggedUserId());
        if (loggedUser == null)
        {
            return Unauthorized();
        }

        var article = await _articleService.FavoriteArticleAsync(loggedUser, slug);

        var articleResponse = MapArticleToViewModel(loggedUser, article);
        return Ok(new
        {
            Article = articleResponse
        });
    }

    [Authorize]
    [HttpDelete("{slug}/favorite")]
    public async Task<IActionResult> UnfavoriteArticle([FromRoute] string slug)
    {
        var loggedUser = await _userService.GetLoggedUserAsync(User.GetLoggedUserId());
        if (loggedUser == null)
        {
            return Unauthorized();
        }

        var article = await _articleService.UnfavoriteArticleAsync(loggedUser, slug);

        var articleResponse = MapArticleToViewModel(loggedUser, article);
        return Ok(new
        {
            Article = articleResponse
        });
    }

    private IEnumerable<CommentResponseViewModel> MapCommentsToViewModels(UserModel loggedUser, List<CommentModel> comments) =>
        comments.Select(comment => MapCommentToViewModel(loggedUser, comment));

    private CommentResponseViewModel MapCommentToViewModel(UserModel loggedUser, CommentModel comment) =>
        new CommentResponseViewModel
        {
            Id = comment.Id,
            Body = comment.Body,
            CreatedAt = comment.CreatedAt,
            UpdatedAt = comment.UpdatedAt,
            Author = new CommentAuthorResponseViewModel
            {
                Bio = comment.Author.Bio,
                Following = comment.Author.Followers.Contains(loggedUser),
                Image = comment.Author.Image,
                Username = comment.Author.Username
            }
        };

    private ICollection<TagModel> MapTagListToTagsModels(IEnumerable<string> tagList) =>
        tagList != null
            ? tagList.Select(t => new TagModel { Name = t }).ToList()
            : new List<TagModel>();

    private IEnumerable<ArticleResponseViewModel> MapArticlesToViewModels(UserModel loggedUser, List<ArticleModel> articles) =>
        articles.Select(article => MapArticleToViewModel(loggedUser, article));

    private ArticleResponseViewModel MapArticleToViewModel(UserModel loggedUser, ArticleModel article) =>
        new ArticleResponseViewModel
        {
            Author = new AuthorViewModel
            {
                Bio = article.Author.Bio,
                Following = IsLoggedUserFollowingAuthor(loggedUser, article),
                Image = article.Author.Image,
                Username = article.Author.Username,
            },
            Body = article.Body,
            CreatedAt = article.CreatedAt,
            Description = article.Description,
            Favorited = IsArticleFavoritedByLoggedUser(loggedUser, article),
            FavoritesCount = article.FavoritedBy.Count,
            Slug = article.Slug,
            TagList = article.Tags.Select(tag => tag.Name),
            Title = article.Title,
            UpdatedAt = article.UpdatedAt
        };

    private bool IsArticleFavoritedByLoggedUser(UserModel loggedUser, ArticleModel article) =>
        loggedUser != null && loggedUser.Favorites.Contains(article);

    private bool IsLoggedUserFollowingAuthor(UserModel loggedUser, ArticleModel article) =>
        loggedUser != null && loggedUser.Following.Contains(article.Author);
}