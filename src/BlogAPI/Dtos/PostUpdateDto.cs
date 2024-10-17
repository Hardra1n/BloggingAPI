namespace BlogAPI.Dtos;
public record PostUpdateDto(int PostId, string Title, string Content)
{
    public Post ToPost()
    {
        return new Post
        {
            PostId = PostId,
            Title = Title,
            Content = Content
        };
    }
}