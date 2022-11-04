using Microsoft.AspNetCore.Mvc;
using RealWorld.Api.Repositories;
using RealWorld.Api.ViewModels;

namespace RealWorld.Api.Controllers;

[Route("api/tags")]
public class TagController : ControllerBase
{
    private readonly ITagRepository _tagRepository;

    public TagController(ITagRepository tagRepository) => _tagRepository = tagRepository;

    [HttpGet]
    public async Task<IActionResult> GetTags()
    {
        var tags = await _tagRepository.GetTagsAsync();
        var tagsResponseViewModel = new TagsResponseViewModel
        {
            Tags = tags.Select(tag => tag.Name).ToList()
        };
        return Ok(tagsResponseViewModel);
    }
}