using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealWorld.Api.Models;

namespace RealWorld.Api.Data.Mappings;

public class UserMap : IEntityTypeConfiguration<UserModel>
{
    public void Configure(EntityTypeBuilder<UserModel> builder)
    {
        builder.ToTable("USERS");

        builder.HasKey(user => user.Id);

        builder.Property(user => user.Id)
            .HasColumnType("INT")
            .IsRequired()
            .ValueGeneratedOnAdd();

        builder.Property(user => user.Email)
            .HasColumnType("VARCHAR(100)")
            .IsRequired();

        builder.Property(user => user.PasswordHash)
            .HasColumnType("VARCHAR(100)")
            .IsRequired();

        builder.Property(user => user.Username)
            .HasColumnType("VARCHAR(100)")
            .IsRequired();

        builder.Property(user => user.Bio)
            .HasColumnType("VARCHAR(500)")
            .IsRequired(false);

        builder.Property(user => user.Image)
           .HasColumnType("VARCHAR(255)")
           .IsRequired(false);

        builder
            .HasMany(user => user.Articles)
            .WithOne(article => article.Author)
            .IsRequired();

        builder
            .HasMany(user => user.Favorites)
            .WithMany(articles => articles.FavoritedBy)
            .UsingEntity<Dictionary<string, object>>(
                "FAVORITES",
                j => j
                        .HasOne<ArticleModel>()
                        .WithMany()
                        .HasForeignKey("ArticleSlug")
                        .OnDelete(DeleteBehavior.NoAction),
                j => j
                        .HasOne<UserModel>()
                        .WithMany()
                        .HasForeignKey("FavoritedBy")
                        .OnDelete(DeleteBehavior.NoAction)
            );

        builder
            .HasMany(user => user.Followers)
            .WithMany(user => user.Following)
            .UsingEntity<Dictionary<string, object>>(
                "FOLLOWERS",
                j => j
                        .HasOne<UserModel>()
                        .WithMany()
                        .HasForeignKey("FollowedBy")
                        .OnDelete(DeleteBehavior.NoAction),
                j => j
                        .HasOne<UserModel>()
                        .WithMany()
                        .HasForeignKey("Follow")
                        .OnDelete(DeleteBehavior.NoAction)
            );

        builder.HasIndex(user => user.Email).IsUnique();
    }
}