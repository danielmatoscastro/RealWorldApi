using Bogus;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealWorld.Api.Models;

namespace RealWorld.Api.Data.Seeders;

public static class CommentSeeder
{
    public static List<CommentModel> GetTestComments()
    {
        var testArticles = ArticleSeeder.GetTestArticles();
        var testUsers = UserSeeder.GetTestUsers();

        Randomizer.Seed = new Random(0);

        var commentId = 1;
        var testComments = new Faker<CommentModel>()
            .RuleFor(c => c.Article, f => f.PickRandom(testArticles))
            .RuleFor(c => c.Author, f => f.PickRandom(testUsers))
            .RuleFor(c => c.Body, f => f.Lorem.Sentence())
            .RuleFor(c => c.CreatedAt, (f, c) => f.Date.BetweenOffset(c.Article.CreatedAt, c.Article.CreatedAt.AddDays(1)))
            .RuleFor(c => c.Id, f => commentId++)
            .RuleFor(c => c.UpdatedAt, (f, c) => c.CreatedAt);

        return testComments.Generate(20);
    }

    public static void Seed(this EntityTypeBuilder<CommentModel> builder)
    {
        var comments = GetTestComments().Select(c => new
        {
            ArticleSlug = c.Article.Slug,
            AuthorId = c.Author.Id,
            Body = c.Body,
            CreatedAt = c.CreatedAt,
            Id = c.Id,
            UpdatedAt = c.UpdatedAt
        });

        builder.HasData(comments);
    }
}