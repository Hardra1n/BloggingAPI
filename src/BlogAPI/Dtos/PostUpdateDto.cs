using System.ComponentModel.DataAnnotations;

namespace BlogAPI.Dtos;
public record PostUpdateDto
{
    public PostUpdateDto(int postId, string title, string content)
    {
        PostId = postId;
        Title = title;
        Content = content;
    }


    [Required]
    public int? PostId { get; set; }

    [Required]
    [Length(1, 30)]
    public string Title { get; set; } = string.Empty;

    [Required]
    [Length(1, 4000)]
    public string Content { get; set; } = string.Empty;


    public Post ToPost()
    {
        return new Post
        {
            PostId = (int)PostId!,
            Title = Title,
            Content = Content
        };
    }
}