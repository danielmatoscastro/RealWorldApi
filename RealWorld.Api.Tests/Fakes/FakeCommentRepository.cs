namespace RealWorld.Api.Tests.Fakes;

using RealWorld.Api.DTOs;
using RealWorld.Api.Models;
using RealWorld.Api.Repositories;

public class FakeCommentRepository : ICommentRepository
{
    private readonly List<CommentModel> _commentModels;

    public FakeCommentRepository(params CommentModel[] commentModels) => _commentModels = commentModels.ToList();


    public Task AddCommentAsync(CommentModel commentModel)
    {
        throw new NotImplementedException();
    }

    public Task<List<CommentModel>> GetCommentsBySlugAsync(string slug)
    {
        throw new NotImplementedException();
    }

    public Task<CommentModel> GetCommentByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(CommentModel comment)
    {
        throw new NotImplementedException();
    }
}