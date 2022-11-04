using RealWorld.Api.Models;

namespace RealWorld.Api.Repositories;

public interface ITagRepository
{
    public Task<List<TagModel>> GetTagsAsync();
}