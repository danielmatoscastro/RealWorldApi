using RealWorld.Api.Models;

namespace RealWorld.Api.Services.Abstraction;

public interface IUserService
{
    Task<UserModel> GetLoggedUserAsync(int? loggedUserId);
    Task<(UserModel, string)> LoginAsync(string email, string password);
    
    Task<UserModel> CreateUserAsync(string username, string email, string password);
    Task<UserModel> UpdateUserAsync(int? loggedUserId, string username, string bio, string email, string password);
    Task<UserModel> UploadUserImageAsync(int? loggedUserId, string image);
}