using System.ComponentModel.DataAnnotations;


namespace MorningEx.Models;

public class Message
{
      
    [Key]
    public int Id { get; set; }

    [Required, StringLength(30)]
    public string Direction { get; set; } = string.Empty;

    [Required, StringLength(50)]
    public string Body { get; set; } = string.Empty;

    [Required]
    public DateTime TimeStamp { get; set; }

    public int ChannelId { get; set; }

    public Channel Channel { get; set; } = null!;
}
