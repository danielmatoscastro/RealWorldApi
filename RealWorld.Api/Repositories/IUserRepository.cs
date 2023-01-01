using RealWorld.Api.Models;

namespace RealWorld.Api.Repositories;

public interface IUserRepository
{
    public Task<UserModel> FindUserByIdAsync(int id);
    public Task<UserModel> FindUserByEmailAsync(string email);
    public Task<UserModel> FindUserByUsernameAsync(string username);
    public Task CreateUserAsync(UserModel model);
    public Task UpdateUserAsync(UserModel model);
}