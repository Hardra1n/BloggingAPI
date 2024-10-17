using BlogAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace BlogAPI.Controllers;

[ApiController]
[Route("api/posts")]
public class PostController : ControllerBase
{
    IPostService _blogService;
    public PostController(IPostService blogService)
    {
        _blogService = blogService;
    }

    [HttpGet]
    public IActionResult GetBlogs()
    {
        return Ok(_blogService.GetPosts());
    }
}