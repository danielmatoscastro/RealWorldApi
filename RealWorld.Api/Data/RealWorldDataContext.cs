using Microsoft.EntityFrameworkCore;
using RealWorld.Api.Data.Mappings;
using RealWorld.Api.Models;

namespace RealWorld.Api.Data;

public class RealWorldDataContext : DbContext
{
    public DbSet<UserModel> Users { get; set; }
    public DbSet<ArticleModel> Articles { get; set; }
    public DbSet<CommentModel> Comments { get; set; }
    public DbSet<TagModel> Tags { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        optionsBuilder.UseSqlServer("Server=localhost,1433;Database=RealWorld;User ID=sa;Password=1q2w3e4r@#$");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration<ArticleModel>(new ArticleMap());
        modelBuilder.ApplyConfiguration<UserModel>(new UserMap());
        modelBuilder.ApplyConfiguration<CommentModel>(new CommentMap());
        modelBuilder.ApplyConfiguration<TagModel>(new TagMap());
    }
}