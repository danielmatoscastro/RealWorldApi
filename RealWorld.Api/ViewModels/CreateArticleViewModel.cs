using System.ComponentModel.DataAnnotations;

namespace RealWorld.Api.ViewModels;

public class CreateArticleViewModel
{
    [Required]
    public CreateArticleArticleViewModel Article { get; set; }
}