using RealWorld.Api.DTOs;
using RealWorld.Api.Models;
using RealWorld.Api.Repositories;

namespace RealWorld.Api.Tests.Fakes;

public class FakeArticleRepository : IArticleRepository
{
    public List<ArticleModel> FakeDbSet { get; private set; }

    public FakeArticleRepository(params ArticleModel[] articleModels) => FakeDbSet = articleModels.ToList();
    
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
        FakeDbSet.Add(articleModel);
        return Task.CompletedTask;
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