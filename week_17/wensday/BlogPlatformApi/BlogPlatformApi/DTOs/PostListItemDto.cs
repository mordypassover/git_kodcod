using BlogPlatformApi.Models;
using System.ComponentModel.DataAnnotations;

namespace BlogPlatformApi.DTOs;

public class PostListItemDto
{
    public string PostTitle { get; set; }

    public int PostId { get; set; }

    public string AuthorName { get; set; }


    public string ContentCount { get; set; }
}