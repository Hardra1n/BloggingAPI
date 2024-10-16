
public class EntityRepository : IBlogRepository
{
    public BloggingContext _context;
    public EntityRepository(BloggingContext context)
    {
        _context = context;
    }

    public IEnumerable<Blog> GetAllBlogs()
    {
        return _context.Blogs.ToList();
    }
}
