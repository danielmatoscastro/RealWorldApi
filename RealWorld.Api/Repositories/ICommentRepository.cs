using RealWorld.Api.Models;

namespace RealWorld.Api.Repositories;

public interface ICommentRepository
{
    public Task AddCommentAsync(CommentModel commentModel);
    public Task<List<CommentModel>> GetCommentsBySlugAsync(string slug);
    public Task<CommentModel> GetCommentByIdAsync(int id);
    public Task DeleteAsync(CommentModel comment);
}
