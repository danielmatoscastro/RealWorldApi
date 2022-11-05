using System.ComponentModel.DataAnnotations;

namespace RealWorld.Api.ViewModels;

public class UploadUserImageViewModel
{
    [Required]
    public UploadUserImageUserViewModel User { get; set; }
}