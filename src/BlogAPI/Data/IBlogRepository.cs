namespace BlogAPI.Data;

public interface IBlogRepository
{
    IEnumerable<Post> GetAllPosts();
    Post GetById(int id);
    void Update(Post post);
    void Delete(int id);
    void Create(Post post);
}