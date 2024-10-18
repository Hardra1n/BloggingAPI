namespace BlogAPI.Data;

public interface IBlogRepository
{
    IQueryable<Post> Posts { get; }
    IEnumerable<Post> GetAllPosts();
    Post GetById(int id);
    void Update(Post post);
    void Delete(int id);
    void Create(Post post);
}