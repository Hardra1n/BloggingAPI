namespace BlogAPI.Dtos;
public record PostCreateDto(string Title, string Content)
{
    public Post ToPost()
    {
        return new Post()
        {
            Title = Title,
            Content = Content
        };
    }
}