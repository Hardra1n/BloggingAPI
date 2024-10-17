namespace BlogAPI.Services;

public interface IPostService
{
    IEnumerable<Post> GetPosts();
    Post GetPost(int id);
    void DeletePost(int id);
    void AddPost(Post post);
    void UpdatePost(Post post);
}