using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealWorld.Api.Data.Seeders;
using RealWorld.Api.Models;

namespace RealWorld.Api.Data.Mappings;

public class CommentMap : IEntityTypeConfiguration<CommentModel>
{
    public void Configure(EntityTypeBuilder<CommentModel> builder)
    {
        builder.ToTable("COMMENTS");

        builder.HasKey(comment => comment.Id);

        builder.Property(comment => comment.Id)
            .HasColumnType("INT")
            .IsRequired()
            .ValueGeneratedOnAdd();

        builder.Property(comment => comment.Body)
            .HasColumnType("VARCHAR(500)")
            .IsRequired();

        builder.Property(comment => comment.CreatedAt)
            .HasColumnType("DATETIMEOFFSET")
            .IsRequired();

        builder.Property(comment => comment.UpdatedAt)
            .HasColumnType("DATETIMEOFFSET")
            .IsRequired();

        builder
            .HasOne(comment => comment.Author)
            .WithMany(user => user.Comments)
            .OnDelete(DeleteBehavior.NoAction)
            .IsRequired();

        builder
            .HasOne(comment => comment.Article)
            .WithMany(article => article.Comments)
            .OnDelete(DeleteBehavior.NoAction)
            .IsRequired();

        builder.Seed();
    }
}
