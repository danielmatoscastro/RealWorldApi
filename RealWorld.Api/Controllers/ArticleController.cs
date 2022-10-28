using Microsoft.AspNetCore.Mvc;
using RealWorld.Api.Models;
using RealWorld.Api.Queries;
using RealWorld.Api.Repositories;
using RealWorld.Api.ViewModels;

namespace RealWorld.Api.Controllers;

[ApiController]
[Route("api/articles")]
public class ArticleController : ControllerBase
{
    private readonly IUserRepository _userRepo;
    private readonly IArticleRepository _articleRepo;

    public ArticleController(IUserRepository userRepo, IArticleRepository articleRepo)
    {
        _userRepo = userRepo;
        _articleRepo = articleRepo;
    }

    [HttpGet]
    public async Task<IActionResult> GetArticles([FromQuery] ArticleQuery articleQuery)
    {
        var loggedUser = await GetLoggedUser();

        var articles = await _articleRepo.Search(articleQuery);

        var articlesResponse = articles.Select(article => new ArticleResponseViewModel
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
        });

        return Ok(new
        {
            Articles = articlesResponse,
            ArticlesCount = articlesResponse.Count(),
        });
    }

    private bool IsArticleFavoritedByLoggedUser(UserModel loggedUser, ArticleModel article) =>
        loggedUser != null ? loggedUser.Favorites.Contains(article) : false;


    private bool IsLoggedUserFollowingAuthor(UserModel loggedUser, ArticleModel article) =>
        loggedUser != null ? loggedUser.Following.Contains(article.Author) : false;

    private async Task<UserModel> GetLoggedUser() =>
        User.Identity.IsAuthenticated && User.GetLoggedUserId() != null
            ? await _userRepo.FindByIdAsync(User.GetLoggedUserId().Value)
            : null;

}