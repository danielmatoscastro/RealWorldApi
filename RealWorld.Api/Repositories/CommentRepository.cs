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

    public async Task DeleteAsync(CommentModel comment)
    {
        _context.Comments.Remove(comment);
        await _context.SaveChangesAsync();
    }

    public Task<CommentModel> GetCommentByIdAsync(int id) =>
        _context.Comments
            .Include(comment => comment.Article)
            .Include(comment => comment.Author)
            .FirstOrDefaultAsync(comment => comment.Id == id);


    public Task<List<CommentModel>> GetCommentsBySlugAsync(string slug) =>
        _context.Comments
            .Include(comment => comment.Article)
            .Include(comment => comment.Author)
            .ThenInclude(author => author.Followers)
            .Where(comment => comment.Article.Slug == slug)
            .ToListAsync();

}