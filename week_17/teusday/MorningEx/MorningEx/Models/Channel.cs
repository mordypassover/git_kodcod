using System.ComponentModel.DataAnnotations;

namespace MorningEx.Models;

public class Channel
{
    public int Id { get; set; }

    [Required, StringLength(30)]
    public string ChannelName { get; set; } = string.Empty;

    [Required,StringLength(50)]
    public string FromPost {  get; set; } = string.Empty;

    [Required, StringLength(50)]
    public string ToPost { get; set; } = string.Empty;

    [Required, StringLength(50)]
    public string Zone { get; set; } = string.Empty;

    [RegularExpression("^connected|disconected$")]
    public string Status {  get; set; } = string.Empty;

    public ICollection<Message> Messages { get; set; } = new List<Message>();

}
