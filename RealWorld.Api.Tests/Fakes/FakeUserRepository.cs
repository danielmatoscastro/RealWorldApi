using RealWorld.Api.Models;
using RealWorld.Api.Repositories;

namespace RealWorld.Api.Tests.Fakes;

public class FakeUserRepository : IUserRepository
{
    private readonly List<UserModel> _userModels;

    public FakeUserRepository(params UserModel[] userModels) => _userModels = userModels.ToList();

    public Task<UserModel?> FindUserByIdAsync(int id) => Task.FromResult(_userModels.FirstOrDefault(x => x.Id == id));

    public Task<UserModel?> FindUserByEmailAsync(string email) =>  
        Task.FromResult(_userModels.FirstOrDefault(x => x.Email == email));

    public Task<UserModel?> FindUserByUsernameAsync(string username) => 
        Task.FromResult(_userModels.FirstOrDefault(x => x.Username == username));

    public Task CreateUserAsync(UserModel model)
    {
        _userModels.Add(model);
        return Task.CompletedTask;
    }

    public Task UpdateUserAsync(UserModel model)
    {
        _userModels.RemoveAll(x => x.Id == model.Id);
        _userModels.Add(model);
        return Task.CompletedTask;
    }
}