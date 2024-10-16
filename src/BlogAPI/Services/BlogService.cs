
public class BlogService : IBlogService
{
    private IBlogRepository _blogRepository;
    public BlogService(IBlogRepository blogRepository)
    {
        _blogRepository = blogRepository;
    }

    public IEnumerable<Blog> GetBlogs()
    {
        return _blogRepository.GetAllBlogs();
    }
}