using Microsoft.EntityFrameworkCore;
using RealWorld.Api.Data;
using RealWorld.Api.Models;

namespace RealWorld.Api.Repositories;

public class UserRepository : IUserRepository
{
    private readonly RealWorldDataContext _context;

    public UserRepository(RealWorldDataContext context) => _context = context;

    public async Task CreateUserAsync(UserModel model)
    {
        await _context.Users.AddAsync(model);
        await _context.SaveChangesAsync();
    }

    public Task<UserModel> FindUserByEmailAsync(string email) =>
        _context.Users
            .Include(x => x.Followers)
            .Include(x => x.Following)
            .Include(x => x.Favorites)
            .FirstOrDefaultAsync(x => x.Email == email);

    public Task<UserModel> FindUserByIdAsync(int id) =>
        _context.Users
            .Include(x => x.Followers)
            .Include(x => x.Following)
            .Include(x => x.Favorites)
            .FirstOrDefaultAsync(x => x.Id == id);

    public Task<UserModel> FindUserByUsernameAsync(string username) =>
        _context.Users
            .Include(x => x.Followers)
            .Include(x => x.Following)
            .Include(x => x.Favorites)
            .FirstOrDefaultAsync(u => u.Username == username);

    public async Task UpdateUserAsync(UserModel model)
    {
        _context.Users.Update(model);
        await _context.SaveChangesAsync();
    }
}