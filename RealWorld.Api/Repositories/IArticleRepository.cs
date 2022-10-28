using RealWorld.Api.Models;
using RealWorld.Api.Queries;

namespace RealWorld.Api.Repositories;

public interface IArticleRepository
{
    public Task<List<ArticleModel>> SearchAsync(ArticleQuery articleQuery);
    public Task<List<ArticleModel>> GetFeedArticlesAsync(UserModel loggedUser, int limit, int offset);
    public Task<ArticleModel> GetArticleBySlug(string slug);
}