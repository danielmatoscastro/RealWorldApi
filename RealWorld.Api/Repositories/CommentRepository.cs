using Microsoft.EntityFrameworkCore;
using RealWorld.Api.Data;
using RealWorld.Api.Models;

namespace RealWorld.Api.Repositories;

public class CommentRepository : ICommentRepository
{
    private readonly RealWorldDataContext _context;

    public CommentRepository(RealWorldDataContext context) => _context = context;

    public async Task AddCommentAsync(CommentModel commentModel)
    {
        await _context.Comments.AddAsync(commentModel);
        await _context.SaveChangesAsync();
    }

    public Task<List<CommentModel>> GetCommentsBySlugAsync(string slug) =>
        _context.Comments
            .Include(comment => comment.Article)
            .Include(comment => comment.Author)
            .ThenInclude(author => author.Followers)
            .Where(comment => comment.Article.Slug == slug)
            .ToListAsync();

}