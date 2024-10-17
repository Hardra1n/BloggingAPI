namespace BlogAPI.Data;

public interface IBlogRepository
{
    IEnumerable<Post> GetAllPosts();
}