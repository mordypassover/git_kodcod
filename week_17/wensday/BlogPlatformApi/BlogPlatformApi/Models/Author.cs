using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BlogPlatformApi.Models
{
    public class Author
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string FullName {  get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } =string.Empty;

        [Required]
        public DateTime JoineDate { get; set; }

       
        public ICollection<Post> Posts { get; } = new List<Post>(); 
    }
}
