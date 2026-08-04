using System;
using System.ComponentModel.DataAnnotations;
using System.Xml;

namespace LibreryApi.models;

public class Member
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string FullName {  get; set; } = string.Empty;

    [Required]
    [EmailAddress]
    public string Email {  get; set; } = string.Empty;

    [Required]
    [StringLength(20)]
    public string MembershipNumber {  get; set; } = string.Empty;

    public DateTime JoinedDate { get; set; }
}
