namespace RealWorld.Api.Models;

public class UserModel
{
    public int Id { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public string Username { get; set; }
    public string Bio { get; set; }
    public string Image { get; set; }
    public ICollection<ArticleModel> Articles { get; set; }
    public ICollection<ArticleModel> Favorites { get; set; }
    public ICollection<CommentModel> Comments { get; set; }
    public ICollection<UserModel> Followers { get; set; }
    public ICollection<UserModel> Following { get; set; }
}