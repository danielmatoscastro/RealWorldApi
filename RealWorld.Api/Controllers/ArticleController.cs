using Microsoft.AspNetCore.Mvc;
using RealWorld.Api.Queries;
using RealWorld.Api.Repositories;

namespace RealWorld.Api.Controllers;

[ApiController]
[Route("api/articles")]
public class ArticleController : ControllerBase
{
    private readonly IArticleRepository _repository;

    public ArticleController(IArticleRepository repository) => _repository = repository;

    [HttpGet]
    public async Task<IActionResult> GetArticles([FromQuery] ArticleQuery articleQuery)
    {
        var articles = await _repository.Search(articleQuery);
        return Ok(articles);
    }
}