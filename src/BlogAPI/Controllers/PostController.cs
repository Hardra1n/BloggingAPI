using BlogAPI.Exceptions;
using BlogAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace BlogAPI.Controllers;

[ApiController]
[Route("api/posts")]
public class PostController : ControllerBase
{
    IPostService _postService;
    public PostController(IPostService postService)
    {
        _postService = postService;
    }

    [HttpGet]
    public IActionResult GetPosts()
    {
        return Ok(_postService.GetPosts());
    }

    [HttpGet("{id}")]
    public IActionResult GetPostById(int id)
    {
        try
        {
            return Ok(_postService.GetPost(id));
        }
        catch (NotFoundException<Post> ex)
        {
            return NotFound(ex.Message);
        }
    }

    [HttpPost]
    public IActionResult CreatePost(Post post)
    {
        _postService.AddPost(post);
        return Created(nameof(GetPostById), null);
    }

    [HttpPut]
    public IActionResult UpdatePost(Post post)
    {
        try
        {
            _postService.UpdatePost(post);
            return Ok();
        }
        catch (NotFoundException<Post> ex)
        {
            return NotFound(ex.Message);
        }
    }

    [HttpDelete("{id}")]
    public IActionResult DeletePost(int id)
    {
        try
        {
            _postService.DeletePost(id);
            return Ok();
        }
        catch (NotFoundException<Post> ex)
        {
            return NotFound(ex.Message);
        }
    }
}