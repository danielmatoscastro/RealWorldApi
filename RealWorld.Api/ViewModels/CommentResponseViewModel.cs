namespace RealWorld.Api.ViewModels;

public class CommentResponseViewModel
{
    public int Id { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
    public string Body { get; set; }
    public CommentAuthorResponseViewModel Author { get; set; }
}