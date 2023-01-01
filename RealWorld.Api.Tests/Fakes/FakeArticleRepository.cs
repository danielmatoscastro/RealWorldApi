using RealWorld.Api.DTOs;
using RealWorld.Api.Models;
using RealWorld.Api.Repositories;

namespace RealWorld.Api.Tests.Fakes;

public class FakeArticleRepository : IArticleRepository
{
    private readonly List<ArticleModel> _articleModels;

    public FakeArticleRepository(params ArticleModel[] articleModels) => _articleModels = articleModels.ToList();
    
    public Task<List<ArticleModel>> GetArticlesAsync(ArticleSearchParamsDTO searchParams)
    {
        throw new NotImplementedException();
    }

    public Task<List<ArticleModel>> GetFeedArticlesAsync(UserModel loggedUser, int limit, int offset)
    {
        throw new NotImplementedException();
    }

    public Task<ArticleModel> GetArticleBySlugAsync(string slug)
    {
        throw new NotImplementedException();
    }

    public Task CreateArticleAsync(ArticleModel articleModel)
    {
        throw new NotImplementedException();
    }

    public Task UpdateArticleAsync(ArticleModel articleModelDb)
    {
        throw new NotImplementedException();
    }

    public Task DeleteArticleAsync(ArticleModel article)
    {
        throw new NotImplementedException();
    }
}