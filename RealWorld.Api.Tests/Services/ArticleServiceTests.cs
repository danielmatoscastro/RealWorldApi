using FluentAssertions;
using RealWorld.Api.Models;
using RealWorld.Api.Repositories;
using RealWorld.Api.Services;
using RealWorld.Api.Tests.Fakes;

namespace RealWorld.Api.Tests.Services;

public class ArticleServiceTests
{

    private readonly IArticleRepository _fakeArticleRepo;
    private readonly ICommentRepository _fakeCommentRepository;
    public ArticleServiceTests()
    {
        _fakeArticleRepo = new FakeArticleRepository();
        _fakeCommentRepository = new FakeCommentRepository();
    }

    [Fact]
    public async Task CreateArticleAsync_ShouldCreateArticle()
    {
        
        var service = new ArticleService(_fakeArticleRepo, new FakeCommentRepository());
        var author = new UserModel { Id = 5 };
        var body = "short body";
        var description = "some description";
        var title = "some title";
        var tags = new[] { "tag1", "tag2", "tag3" };

        var article = await service.CreateArticleAsync(author, body, description, title, tags);

        ((FakeArticleRepository)_fakeArticleRepo).FakeDbSet.Contains(article).Should().BeTrue();
        article.Author.Should().Be(author);
        article.Body.Should().Be(body);
        article.Description.Should().Be(description);
        article.Title.Should().Be(title);
        article.Slug.Should().NotBeEmpty();
        article.Tags.All(t => tags.Contains(t.Name)).Should().BeTrue();
        article.Comments.Should().BeEmpty();
        article.FavoritedBy.Should().BeEmpty();
        article.CreatedAt.Should().BeCloseTo(DateTimeOffset.Now, TimeSpan.FromSeconds(5));
        article.UpdatedAt.Should().BeCloseTo(DateTimeOffset.Now, TimeSpan.FromSeconds(5));
    }
}