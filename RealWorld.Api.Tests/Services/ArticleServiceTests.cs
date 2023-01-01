using RealWorld.Api.Models;
using RealWorld.Api.Repositories;
using RealWorld.Api.Tests.Fakes;

namespace RealWorld.Api.Tests.Services;

public class ArticleServiceTests
{

    private readonly IArticleRepository _fakeArticleRepo;

    public ArticleServiceTests()
    {
        _fakeArticleRepo = new FakeArticleRepository(GenerateLongListOfArticles());
    }

    private ArticleModel[] GenerateLongListOfArticles()
    {
        throw new NotImplementedException();
    }
    
}