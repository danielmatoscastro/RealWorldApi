namespace RealWorld.Api.Queries;

public class ArticleQuery
{
    public string Author { get; init; }
    public string Tag { get; init; }
    public string Favorited { get; init; }
    public int Limit { get; set; } = 20;
    public int Offset { get; set; } = 0;
}