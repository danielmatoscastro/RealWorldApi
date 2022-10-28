using System.ComponentModel.DataAnnotations;

namespace RealWorld.Api.ViewModels;

public class UpdateArticleViewModel
{
    [Required]
    public UpdateArticleArticleViewModel Article { get; set; }
}