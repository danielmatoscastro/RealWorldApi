using System.ComponentModel.DataAnnotations;

namespace RealWorld.Api.ViewModels;

public class CreateUserUserViewModel
{
    [Required]
    public string Username { get; init; }

    [Required]
    [EmailAddress]
    public string Email { get; init; }

    [Required]
    public string Password { get; init; }
}
