namespace RealWorld.Api.DTOs;

public class ArticleSearchParamsDTO
{
    public string Author { get; init; }
    public string Tag { get; init; }
    public string Favorited { get; init; }
    public int Limit { get; set; } = 20;
    public int Offset { get; set; } = 0;
}