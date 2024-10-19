using BlogAPI.Data;

namespace BlogAPI.Services;

public class PostService : IPostService
{
    private IBlogRepository _blogRepository;
    public PostService(IBlogRepository blogRepository)
    {
        _blogRepository = blogRepository;
    }

    public void AddPost(Post post)
    {
        _blogRepository.Create(post);
    }

    public void DeletePost(int id) => _blogRepository.Delete(id);

    public Post GetPost(int id) => _blogRepository.GetById(id);

    public IEnumerable<Post> GetPosts() => _blogRepository.GetAllPosts();

    public void UpdatePost(Post post)
    {
        post.CreatedAt = GetPost(post.PostId).CreatedAt;
        _blogRepository.Update(post);
    }
}