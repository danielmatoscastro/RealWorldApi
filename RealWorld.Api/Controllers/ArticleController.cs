using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RealWorld.Api.Models;
using RealWorld.Api.Queries;
using RealWorld.Api.Repositories;
using RealWorld.Api.ViewModels;
using SlugGenerator;

namespace RealWorld.Api.Controllers;

[ApiController]
[Route("api/articles")]
public class ArticleController : ControllerBase
{
    private readonly IUserRepository _userRepo;
    private readonly IArticleRepository _articleRepo;
    private readonly ICommentRepository _commentRepo;

    public ArticleController(IUserRepository userRepo, IArticleRepository articleRepo, ICommentRepository commentRepo)
    {
        _userRepo = userRepo;
        _articleRepo = articleRepo;
        _commentRepo = commentRepo;
    }

    [HttpGet]
    public async Task<IActionResult> GetArticles([FromQuery] ArticleQuery articleQuery)
    {
        var loggedUser = await GetLoggedUser();

        var articles = await _articleRepo.SearchAsync(articleQuery);

        var articlesResponse = MapArticlesToViewModels(loggedUser, articles);
        return Ok(new
        {
            Articles = articlesResponse,
            ArticlesCount = articlesResponse.Count(),
        });
    }

    [Authorize]
    [HttpGet("feed")]
    public async Task<IActionResult> GetFeed([FromQuery] int limit = 20, [FromQuery] int offset = 0)
    {
        var loggedUser = await GetLoggedUser();
        if (loggedUser == null)
        {
            return Unauthorized();
        }

        var articles = await _articleRepo.GetFeedArticlesAsync(loggedUser, limit, offset);

        var articlesResponse = MapArticlesToViewModels(loggedUser, articles);
        return Ok(new
        {
            Articles = articlesResponse,
            ArticlesCount = articlesResponse.Count(),
        });
    }

    [HttpGet("{slug}")]
    public async Task<IActionResult> GetArticle([FromRoute] string slug)
    {
        var loggedUser = await GetLoggedUser();

        var article = await _articleRepo.GetArticleBySlug(slug);
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
    public async Task<IActionResult> CreateArticle([FromBody] CreateArticleViewModel payload)
    {
        var loggedUser = await GetLoggedUser();
        if (loggedUser == null)
        {
            return Unauthorized();
        }

        var articleModel = new ArticleModel
        {
            Author = loggedUser,
            Body = payload.Article.Body,
            Description = payload.Article.Description,
            Slug = payload.Article.Title.GenerateSlug(),
            Title = payload.Article.Title,
            UpdatedAt = DateTimeOffset.Now,
            CreatedAt = DateTimeOffset.Now,
            Tags = MapTagListToTagsModels(payload.Article.TagList),
        };
        await _articleRepo.CreateAsync(articleModel);

        var articleResponse = MapArticleToViewModel(loggedUser, articleModel);
        return Ok(new
        {
            Article = articleResponse
        });
    }

    [HttpPatch("{slug}")]
    public async Task<IActionResult> UpdateArticle([FromRoute] string slug, [FromBody] UpdateArticleViewModel payload)
    {
        var loggedUser = await GetLoggedUser();
        if (loggedUser == null)
        {
            return Unauthorized();
        }

        var articleModelDb = await _articleRepo.GetArticleBySlug(slug);
        if (articleModelDb == null)
        {
            return NotFound();
        }

        if (articleModelDb.Author.Id != loggedUser.Id)
        {
            return Forbid();
        }

        if (payload.Article.Title != null)
        {
            articleModelDb.Title = payload.Article.Title;
            articleModelDb.Slug = payload.Article.Title.GenerateSlug();
        }
        if (payload.Article.Description != null)
        {
            articleModelDb.Description = payload.Article.Description;
        }
        if (payload.Article.Body != null)
        {
            articleModelDb.Body = payload.Article.Body;
        }
        await _articleRepo.UpdateAsync(articleModelDb);

        var articleResponse = MapArticleToViewModel(loggedUser, articleModelDb);
        return Ok(new
        {
            Article = articleResponse
        });
    }

    [Authorize]
    [HttpDelete("{slug}")]
    public async Task<IActionResult> DeleteArticle([FromRoute] string slug)
    {
        var loggedUser = await GetLoggedUser();
        if (loggedUser == null)
        {
            return Unauthorized();
        }

        var article = await _articleRepo.GetArticleBySlug(slug);
        if (article == null)
        {
            return NotFound();
        }

        if (article.Author.Id != loggedUser.Id)
        {
            return Forbid();
        }

        await _articleRepo.DeleteArticle(article);

        return NoContent();
    }

    [Authorize]
    [HttpPost("{slug}/comments")]
    public async Task<IActionResult> AddCommentToArticle([FromRoute] string slug, [FromBody] AddCommentViewModel payload)
    {
        var loggedUser = await GetLoggedUser();
        if (loggedUser == null)
        {
            return Unauthorized();
        }

        var article = await _articleRepo.GetArticleBySlug(slug);
        if (article == null)
        {
            return NotFound();
        }

        var comment = new CommentModel
        {
            Author = loggedUser,
            Article = article,
            Body = payload.Comment.Body,
            CreatedAt = DateTimeOffset.Now,
            UpdatedAt = DateTimeOffset.Now,
        };

        await _commentRepo.AddCommentAsync(comment);

        var response = MapCommentToViewModel(loggedUser, comment);

        return Ok(new
        {
            Comment = response
        });
    }

    [HttpGet("{slug}/comments")]
    public async Task<IActionResult> GetAllComments([FromRoute] string slug)
    {
        var loggedUser = await GetLoggedUser();

        var comments = await _commentRepo.GetCommentsBySlugAsync(slug);
        if (comments == null)
        {
            return NotFound();
        }

        return Ok(new
        {
            Comments = MapCommentsToViewModels(loggedUser, comments),
        });
    }

    [Authorize]
    [HttpDelete("{slug}/comments/{id:int}")]
    public async Task<IActionResult> DeleteComment([FromRoute] string slug, [FromRoute] int id)
    {
        var loggedUser = await GetLoggedUser();
        if (loggedUser == null)
        {
            return Unauthorized();
        }

        var comment = await _commentRepo.GetCommentByIdAsync(id);
        if (comment == null)
        {
            return NotFound();
        }

        if (comment.Author.Id != loggedUser.Id)
        {
            return Forbid();
        }

        if (comment.Article.Slug != slug)
        {
            return BadRequest();
        }

        await _commentRepo.DeleteAsync(comment);

        return NoContent();
    }

    [Authorize]
    [HttpPost("{slug}/favorite")]
    public async Task<IActionResult> FavoriteArticle([FromRoute] string slug)
    {
        var loggedUser = await GetLoggedUser();
        if (loggedUser == null)
        {
            return Unauthorized();
        }

        var article = await _articleRepo.GetArticleBySlug(slug);
        if (article == null)
        {
            return NotFound();
        }

        if (article.FavoritedBy.Contains(loggedUser))
        {
            return BadRequest();
        }

        article.FavoritedBy.Add(loggedUser);
        await _articleRepo.UpdateAsync(article);

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
        loggedUser != null ? loggedUser.Favorites.Contains(article) : false;

    private bool IsLoggedUserFollowingAuthor(UserModel loggedUser, ArticleModel article) =>
        loggedUser != null ? loggedUser.Following.Contains(article.Author) : false;

    private async Task<UserModel> GetLoggedUser() =>
        User.Identity.IsAuthenticated && User.GetLoggedUserId() != null
            ? await _userRepo.FindByIdAsync(User.GetLoggedUserId().Value)
            : null;
}