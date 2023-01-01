using System.Text.RegularExpressions;
using RealWorld.Api.Exceptions;
using RealWorld.Api.Models;
using RealWorld.Api.Repositories;
using RealWorld.Api.Services.Abstraction;
using SecureIdentity.Password;

namespace RealWorld.Api.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepo;
    private readonly ITokenService _tokenService;

    public UserService(IUserRepository userRepo, ITokenService tokenService)
    {
        _userRepo = userRepo;
        _tokenService = tokenService;
    }
    
    public async Task<UserModel> GetLoggedUserAsync(int? loggedUserId) => 
        loggedUserId.HasValue ? await _userRepo.FindUserByIdAsync(loggedUserId.Value) : null;
    
    public async Task<(UserModel, string)> LoginAsync(string email, string password)
    {
        var userModelDb = await _userRepo.FindUserByEmailAsync(email);
        if (userModelDb == null)
        {
            throw new EntityNotFoundException("User");
        }

        if (!PasswordHasher.Verify(userModelDb.PasswordHash, password))
        {
            throw new UnauthorizedOperationException(nameof(LoginAsync));
        }

        var token = _tokenService.GenerateToken(userModelDb);

        return (userModelDb, token);
    }

    public async Task<UserModel> CreateUserAsync(string username, string email, string password)
    {
        var userModel = new UserModel
        {
            Username = username,
            Email = email,
            PasswordHash = PasswordHasher.Hash(password),
        };

        await _userRepo.CreateUserAsync(userModel);

        return userModel;
    }

    public async Task<UserModel> UpdateUserAsync(int? loggedUserId, string username, string bio, string email, string password)
    {
        var loggedUser = await GetLoggedUserAsync(loggedUserId);
        if (loggedUser == null)
        {
            throw new EntityNotFoundException("User");
        }

        loggedUser.Username = username;
        loggedUser.Bio = bio;
        loggedUser.Email = email;
        loggedUser.PasswordHash = PasswordHasher.Hash(password);
        await _userRepo.UpdateUserAsync(loggedUser);

        return loggedUser;
    }

    public async Task<UserModel> UploadUserImageAsync(int? loggedUserId, string image)
    {
        var loggedUser = await GetLoggedUserAsync(loggedUserId);
        if (loggedUser == null)
        {
            throw new EntityNotFoundException("User");
        }

        var imageName = $"{Guid.NewGuid().ToString()}.jpg";
        var data = new Regex(@"data:image\/[a-z]*;base64,").Replace(image, string.Empty);
        var dataInBytes = Convert.FromBase64String(data);

        var imagePath = Path.Combine("wwwroot", "images", imageName);
        await System.IO.File.WriteAllBytesAsync(imagePath, dataInBytes);

        loggedUser.Image = imagePath;
        await _userRepo.UpdateUserAsync(loggedUser);

        return loggedUser;
    }
}