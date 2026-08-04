using System;
using System.ComponentModel.DataAnnotations;
using System.Xml;

namespace LibreryApi.models;

public class Book
{

    public int Id { get; set; }

    [Required]
    [StringLength(200)]
    public string Title {  get; set; }  = string.Empty;

    [Required]
    [StringLength(200)]
    public string Author {  get; set; } = string.Empty;
    [Required]
    [StringLength(200)]
    public string ISBN { get; set; } = string.Empty;

    [Range(1800, 2100)]
    public int PublishedYear {  get; set; }

    [Range(1, int.MaxValue)]
    public int AvailableCopies { get; set; }
}
