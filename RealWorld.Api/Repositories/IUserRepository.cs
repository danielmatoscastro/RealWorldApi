using RealWorld.Api.Models;

namespace RealWorld.Api.Repositories;

public interface IUserRepository
{
    public Task<UserModel> FindByIdAsync(int id);
    public Task<UserModel> FindByEmailAsync(string email);
    public Task<UserModel> FindByUsernameAsync(string username);
    public Task CreateAsync(UserModel model);
    public Task UpdateAsync(UserModel model);
}