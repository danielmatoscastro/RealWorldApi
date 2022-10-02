namespace RealWorld.Api.Models;

public class UserModel
{
    public int Id { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public string Username { get; set; }
    public string Bio { get; set; }
    public string Image { get; set; }
    public IEnumerable<ArticleModel> Articles { get; set; }
    public IEnumerable<ArticleModel> Favorites { get; set; }
    public IEnumerable<CommentModel> Comments { get; set; }
    public IEnumerable<UserModel> Followers { get; set; }
    public IEnumerable<UserModel> Following { get; set; }
}