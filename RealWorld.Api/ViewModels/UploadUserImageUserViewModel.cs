using System.ComponentModel.DataAnnotations;

namespace RealWorld.Api.ViewModels;

public class UploadUserImageUserViewModel
{
    [Required]
    public string Image { get; set; }
}
