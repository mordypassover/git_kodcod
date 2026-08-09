using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BlogPlatformApi.Models;

public class Post
{
    public int Id { get; set; }

    public int AuthorId { get; set; }

    [Required]
    [StringLength(150)]
    public string Title { get; set; }

    [Required]
    [StringLength(1000)]
    public string Content { get; set; }

    [Required]
    public DateTime PublishedDate {  get; set; }

    [Required]
    public bool IsPublished {  get; set; }

    public DateTime CreatedAt { get; set; }

    public Author Author { get; set; } = null!;

    public ICollection<Comment> Comments { get; } = new List<Comment>();
}
