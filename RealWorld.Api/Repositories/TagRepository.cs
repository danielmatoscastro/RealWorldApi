using Microsoft.EntityFrameworkCore;
using RealWorld.Api.Data;
using RealWorld.Api.Models;

namespace RealWorld.Api.Repositories;

public class TagRepository : ITagRepository
{
    private readonly RealWorldDataContext _context;

    public TagRepository(RealWorldDataContext context) => _context = context;

    public Task<List<TagModel>> GetTagsAsync() => _context.Tags.ToListAsync();
}