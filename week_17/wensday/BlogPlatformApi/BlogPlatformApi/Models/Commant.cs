using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BlogPlatformApi.Models;

public class Comment
{
    public int Id { get; set; }

    public int PostId {  get; set; }

    [Required]
    [StringLength(30)]
    public string CommenterName {get; set;}

    [Required]
    [StringLength(150)]
    public string Text {get; set;}

    [Required]
    public DateTime CreatedAt { get; set; }

    public Post Post { get; set; } = null!;

}
