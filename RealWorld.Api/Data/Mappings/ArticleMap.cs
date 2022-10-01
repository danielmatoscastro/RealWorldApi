using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealWorld.Api.Models;

namespace RealWorld.Api.Data.Mappings;

public class ArticleMap : IEntityTypeConfiguration<ArticleModel>
{
    public void Configure(EntityTypeBuilder<ArticleModel> builder)
    {
        builder.ToTable("ARTICLE");

        builder.HasKey(article => article.Slug);

        builder.Property(article => article.Slug)
            .HasColumnType("VARCHAR(100)")
            .IsRequired();

        builder.Property(article => article.Title)
            .HasColumnType("VARCHAR(100)")
            .IsRequired();

        builder.Property(article => article.Description)
            .HasColumnType("VARCHAR(500)")
            .IsRequired();

        builder.Property(article => article.Body)
            .HasColumnType("TEXT")
            .IsRequired();

        builder.Property(article => article.CreatedAt)
            .HasColumnType("DATETIMEOFFSET")
            .IsRequired();

        builder.Property(article => article.UpdatedAt)
            .HasColumnType("DATETIMEOFFSET")
            .IsRequired();

        builder
            .HasOne(article => article.Author)
            .WithMany(user => user.Articles)
            .IsRequired();

        builder
            .HasMany(article => article.Tags)
            .WithMany(tag => tag.Articles)
            .UsingEntity<Dictionary<string, object>>(
                "ARTICLES_TAGS",
                j => j
                    .HasOne<TagModel>()
                    .WithMany()
                    .HasForeignKey("TagName")
                    .OnDelete(DeleteBehavior.NoAction),
                j => j
                    .HasOne<ArticleModel>()
                    .WithMany()
                    .HasForeignKey("ArticleSlug")
                    .OnDelete(DeleteBehavior.NoAction)
            );
    }
}