using System.ComponentModel.DataAnnotations;

namespace RealWorld.Api.ViewModels;

public class UpdateUserUserViewModel
{
    [Required]
    public string Email { get; init; }

    [Required]
    public string Username { get; init; }

    [Required]
    public string Password { get; init; }

    [Required]
    public string Bio { get; init; }
}
