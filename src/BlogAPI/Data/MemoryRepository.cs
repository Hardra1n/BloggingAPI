using System.Collections.Concurrent;
using System.Collections.Immutable;

public class MemoryRepository : IBlogRepository
{
    private ConcurrentBag<Blog> _storage;
    public MemoryRepository()
    {
        _storage = new ConcurrentBag<Blog>();
    }

    public void Add(Blog blog)
    {
        _storage.Add(blog);
    }

    public IEnumerable<Blog> GetAllBlogs()
    {
        return _storage.ToImmutableList();
    }
}
