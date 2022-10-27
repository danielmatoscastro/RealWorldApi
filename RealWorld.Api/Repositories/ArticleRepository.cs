using Microsoft.EntityFrameworkCore;
using RealWorld.Api.Data;
using RealWorld.Api.Models;
using RealWorld.Api.Queries;

namespace RealWorld.Api.Repositories;

public class ArticleRepository : IArticleRepository
{
    private readonly RealWorldDataContext _context;

    public ArticleRepository(RealWorldDataContext context) => _context = context;

    public Task<List<ArticleModel>> Search(ArticleQuery articleQuery) =>
        _context.Articles
            .Include(article => article.Author)
            .Include(article => article.FavoritedBy)
            .Include(article => article.Tags)
            .Where(article => articleQuery.Author == null || article.Author.Username == articleQuery.Author)
            .Where(article => articleQuery.Favorited == null || article.FavoritedBy.Any(u => u.Username == articleQuery.Favorited))
            .Where(article => articleQuery.Tag == null || article.Tags.Any(t => t.Name == articleQuery.Tag))
            .OrderByDescending(article => article.CreatedAt)
            .Skip(articleQuery.Offset)
            .Take(articleQuery.Limit)
            .ToListAsync();
}