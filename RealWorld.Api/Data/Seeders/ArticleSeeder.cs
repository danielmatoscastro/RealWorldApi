using Bogus;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealWorld.Api.Models;

namespace RealWorld.Api.Data.Seeders;

public static class ArticleSeeder
{
    private static string PseudoSlugfy(string text) =>
        text
            .Trim()
            .Replace(" ", "-")
            .Replace(".", "")
            .ToLower();

    public static List<ArticleModel> GetTestArticles()
    {
        var testUsers = UserSeeder.GetTestUsers();
        // testUsers.ForEach(u => Console.WriteLine(u.Id));
        Randomizer.Seed = new Random(0);

        var testArticles = new Faker<ArticleModel>()
            .RuleFor(a => a.Author, f => f.PickRandom(testUsers))
            .RuleFor(a => a.Body, f => f.Lorem.Paragraphs())
            .RuleFor(a => a.CreatedAt, f => f.Date.BetweenOffset(DateTimeOffset.Parse("2022-01-01"), DateTimeOffset.Parse("2022-12-01")))
            .RuleFor(a => a.Description, f => f.Lorem.Sentence())
            .RuleFor(a => a.Title, f => f.Lorem.Sentence())
            .RuleFor(a => a.Slug, (f, a) => PseudoSlugfy(a.Title))
            .RuleFor(a => a.UpdatedAt, (f, a) => a.CreatedAt);

        return testArticles.Generate(10);
    }

    public static void Seed(this EntityTypeBuilder<ArticleModel> builder)
    {
        var articles = GetTestArticles().Select(a => new
        {
            AuthorId = a.Author.Id,
            Body = a.Body,
            CreatedAt = a.CreatedAt,
            Description = a.Description,
            Title = a.Title,
            Slug = a.Slug,
            UpdatedAt = a.UpdatedAt
        });

        builder.HasData(articles);
    }
}