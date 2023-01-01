using RealWorld.Api.Models;
using RealWorld.Api.Repositories;

namespace RealWorld.Api.Tests.Fakes;

public class FakeUserRepository : IUserRepository
{
    private readonly List<UserModel> _userModels;

    public FakeUserRepository(params UserModel[] userModels) => _userModels = userModels.ToList();

    public Task<UserModel?> FindByIdAsync(int id) => Task.FromResult(_userModels.FirstOrDefault(x => x.Id == id));

    public Task<UserModel?> FindByEmailAsync(string email) =>  
        Task.FromResult(_userModels.FirstOrDefault(x => x.Email == email));

    public Task<UserModel?> FindByUsernameAsync(string username) => 
        Task.FromResult(_userModels.FirstOrDefault(x => x.Username == username));

    public Task CreateAsync(UserModel model)
    {
        _userModels.Add(model);
        return Task.CompletedTask;
    }

    public Task UpdateAsync(UserModel model)
    {
        _userModels.RemoveAll(x => x.Id == model.Id);
        _userModels.Add(model);
        return Task.CompletedTask;
    }
}