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
}