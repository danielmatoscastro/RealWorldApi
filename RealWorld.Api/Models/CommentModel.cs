namespace RealWorld.Api.Models;

public class CommentModel
{
    public int Id { get; set; }
    public string Body { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
    public UserModel Author { get; set; }
    public ArticleModel Article { get; set; }
}
