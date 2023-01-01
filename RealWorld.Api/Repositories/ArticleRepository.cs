using Microsoft.EntityFrameworkCore;
using RealWorld.Api.Data;
using RealWorld.Api.DTOs;
using RealWorld.Api.Models;

namespace RealWorld.Api.Repositories;

public class ArticleRepository : IArticleRepository
{
    private readonly RealWorldDataContext _context;

    public ArticleRepository(RealWorldDataContext context) => _context = context;

    public Task<List<ArticleModel>> GetFeedArticlesAsync(UserModel loggedUser, int limit, int offset) =>
        _context.Articles
            .Include(article => article.Author)
            .Include(article => article.FavoritedBy)
            .Include(article => article.Tags)
            .Where(article => loggedUser.Following.Contains(article.Author))
            .OrderByDescending(article => article.CreatedAt)
            .Skip(offset)
            .Take(limit)
            .ToListAsync();

    public Task<List<ArticleModel>> SearchAsync(ArticleSearchParamsDTO searchParams) =>
        _context.Articles
            .Include(article => article.Author)
            .Include(article => article.FavoritedBy)
            .Include(article => article.Tags)
            .Where(article => searchParams.Author == null || article.Author.Username == searchParams.Author)
            .Where(article => searchParams.Favorited == null || article.FavoritedBy.Any(u => u.Username == searchParams.Favorited))
            .Where(article => searchParams.Tag == null || article.Tags.Any(t => t.Name == searchParams.Tag))
            .OrderByDescending(article => article.CreatedAt)
            .Skip(searchParams.Offset)
            .Take(searchParams.Limit)
            .ToListAsync();

    public Task<ArticleModel> GetArticleBySlug(string slug) =>
        _context.Articles
            .Include(article => article.Author)
            .Include(article => article.FavoritedBy)
            .Include(article => article.Tags)
            .Include(article => article.Comments)
            .FirstOrDefaultAsync(article => article.Slug == slug);

    public async Task CreateAsync(ArticleModel articleModel)
    {
        await _context.AddAsync(articleModel);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(ArticleModel articleModel)
    {
        _context.Articles.Update(articleModel);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteArticle(ArticleModel articleModel)
    {
        foreach (var comment in articleModel.Comments)
        {
            _context.Comments.Remove(comment);
        }

        _context.Articles.Remove(articleModel);
        await _context.SaveChangesAsync();
    }
}