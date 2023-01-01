using RealWorld.Api.DTOs;
using RealWorld.Api.Models;

namespace RealWorld.Api.Repositories;

public interface IArticleRepository
{
    public Task<List<ArticleModel>> GetArticlesAsync(ArticleSearchParamsDTO searchParams);
    public Task<List<ArticleModel>> GetFeedArticlesAsync(UserModel loggedUser, int limit, int offset);
    public Task<ArticleModel> GetArticleBySlug(string slug);
    public Task CreateAsync(ArticleModel articleModel);
    public Task UpdateAsync(ArticleModel articleModelDb);
    public Task DeleteArticle(ArticleModel article);
}