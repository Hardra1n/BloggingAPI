using BlogAPI.Data;

namespace BlogAPI.Services;

public class PostService : IPostService
{
    private IBlogRepository _blogRepository;
    public PostService(IBlogRepository blogRepository)
    {
        _blogRepository = blogRepository;
    }

    public IEnumerable<Post> GetPosts()
    {
        return _blogRepository.GetAllPosts();
    }
}