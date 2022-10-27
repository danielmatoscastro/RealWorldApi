using Bogus;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealWorld.Api.Models;
using SecureIdentity.Password;

namespace RealWorld.Api.Data.Seeders;

public static class UserSeeder
{
    public static List<UserModel> GetTestUsers()
    {
        Randomizer.Seed = new Random(0);

        var userId = 1;
        var testUsers = new Faker<UserModel>()
            .RuleFor(u => u.Id, f => userId++)
            .RuleFor(u => u.Bio, f => f.Lorem.Sentences(3))
            .RuleFor(u => u.Email, f => f.Internet.Email())
            .RuleFor(u => u.Image, f => f.Internet.Avatar())
            .RuleFor(u => u.PasswordHash, f => PasswordHasher.Hash($"password {userId}"))
            .RuleFor(u => u.Username, f => f.Name.FullName());

        return testUsers.Generate(10);
    }

    public static void Seed(this EntityTypeBuilder<UserModel> builder) => builder.HasData(GetTestUsers());
}