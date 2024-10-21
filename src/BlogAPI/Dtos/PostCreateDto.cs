using System.ComponentModel.DataAnnotations;

namespace BlogAPI.Dtos;
public record PostCreateDto
{

    public PostCreateDto(string title, string content)
    {
        Title = title;
        Content = content;
    }


    [Required]
    [Length(1, 30)]
    public string Title { get; set; } = string.Empty;

    [Required]
    [Length(1, 4000)]
    public string Content { get; set; } = string.Empty;


    public Post ToPost()
    {
        return new Post()
        {
            Title = Title,
            Content = Content
        };
    }
}