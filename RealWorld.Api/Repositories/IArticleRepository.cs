using RealWorld.Api.Models;
using RealWorld.Api.Queries;

namespace RealWorld.Api.Repositories;

public interface IArticleRepository
{
    public Task<List<ArticleModel>> Search(ArticleQuery articleQuery);
}