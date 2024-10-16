public interface IBlogRepository
{
    IEnumerable<Blog> GetAllBlogs();
    void Add(Blog blog);
}