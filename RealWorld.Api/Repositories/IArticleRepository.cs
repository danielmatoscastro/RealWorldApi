using RealWorld.Api.DTOs;
using RealWorld.Api.Models;

namespace RealWorld.Api.Repositories;

public interface IArticleRepository
{
    public Task<List<ArticleModel>> GetArticlesAsync(ArticleSearchParamsDTO searchParams);
    public Task<List<ArticleModel>> GetFeedArticlesAsync(UserModel loggedUser, int limit, int offset);
    public Task<ArticleModel> GetArticleBySlugAsync(string slug);
    public Task CreateArticleAsync(ArticleModel articleModel);
    public Task UpdateArticleAsync(ArticleModel articleModelDb);
    public Task DeleteArticleAsync(ArticleModel article);
}