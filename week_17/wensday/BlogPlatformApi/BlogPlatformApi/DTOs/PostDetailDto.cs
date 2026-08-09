using BlogPlatformApi.Models;

namespace BlogPlatformApi.DTOs
{
    public class PostDetailDto
    {
        public string PostDetail { get; set; }

        public ICollection<Comment> Comments { get; set; } 

    }
}
