using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

public class Post
{
    [Key]
    public int PostId { get; set; }

    [Required]
    [MaxLength(30)]
    public string Title { get; set; } = string.Empty;

    [Required]
    [MaxLength(4000)]
    public string Content { get; set; } = string.Empty;

    [Required]
    public DateTime CreatedAt { get; set; }
}