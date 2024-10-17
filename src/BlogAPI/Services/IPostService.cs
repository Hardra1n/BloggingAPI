namespace BlogAPI.Services;

public interface IPostService
{
    IEnumerable<Post> GetPosts();
}