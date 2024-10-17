namespace BlogAPI.Data;

public class EntityRepository : IBlogRepository
{
    public BloggingContext _context;
    public EntityRepository(BloggingContext context)
    {
        _context = context;
    }

    public IEnumerable<Post> GetAllPosts()
    {
        return _context.Posts.ToList();
    }
}
