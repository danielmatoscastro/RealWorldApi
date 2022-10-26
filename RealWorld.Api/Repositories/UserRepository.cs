using Microsoft.EntityFrameworkCore;
using RealWorld.Api.Data;
using RealWorld.Api.Models;

namespace RealWorld.Api.Repositories;

public class UserRepository : IUserRepository
{
    private readonly RealWorldDataContext _context;

    public UserRepository(RealWorldDataContext context) => _context = context;

    public async Task CreateAsync(UserModel model)
    {
        await _context.Users.AddAsync(model);
        await _context.SaveChangesAsync();
    }

    public Task<UserModel> FindByEmailAsync(string email) =>
        _context.Users
            .FirstOrDefaultAsync(x => x.Email == email);

    public Task<UserModel> FindByIdAsync(int id) =>
        _context.Users
            .FirstOrDefaultAsync(x => x.Id == id);

    public Task<UserModel> FindByUsernameWithFollowersAsync(string username) =>
        _context.Users
            .Include(u => u.Followers)
            .Where(u => u.Username == username)
            .FirstOrDefaultAsync();

    public async Task UpdateAsync(UserModel model)
    {
        _context.Users.Update(model);
        await _context.SaveChangesAsync();
    }
}