using BlogAPI.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace BlogAPI.Data;

public class EntityRepository : IBlogRepository
{
    private BloggingContext _context;
    public EntityRepository(BloggingContext context)
    {
        _context = context;
    }

    public void Create(Post post)
    {
        if (_context.Posts.Any((p) => p.PostId == post.PostId))
            throw new AlreadyExistsException<Post>(post.PostId);
        _context.Posts.Add(post);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        Post postToDelete = _context.Posts.Find(id)
            ?? throw new NotFoundException<Post>(id);

        _context.Posts.Remove(postToDelete);
        _context.SaveChanges();
    }

    public IEnumerable<Post> GetAllPosts()
    {
        return _context.Posts.AsNoTracking().ToList();
    }

    public Post GetById(int id)
    {
        Post entity = _context.Posts.AsNoTracking()
            .FirstOrDefault((post) => post.PostId == id)
            ?? throw new NotFoundException<Post>(id);

        return entity;
    }

    public void Update(Post post)
    {
        if (!_context.Posts.Any((p) => p.PostId == post.PostId))
            throw new NotFoundException<Post>(post.PostId);
        _context.Update(post);
        _context.SaveChanges();
    }
}
