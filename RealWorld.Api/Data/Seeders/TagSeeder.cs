using Bogus;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealWorld.Api.Models;

namespace RealWorld.Api.Data.Seeders;

public static class TagSeeder
{
    public static List<TagModel> GetTestTags()
    {
        Randomizer.Seed = new Random(0);

        var testTag = new Faker<TagModel>()
            .RuleFor(t => t.Name, f => f.Lorem.Word());

        return testTag.Generate(10);
    }

    public static void Seed(this EntityTypeBuilder<TagModel> builder) => builder.HasData(GetTestTags());
}