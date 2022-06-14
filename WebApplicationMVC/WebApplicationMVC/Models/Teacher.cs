using System.ComponentModel.DataAnnotations;

namespace WebApplicationMVC.Models;

public class Teacher
{
    [Key]
    public int Idteacher { get; set; }
    public string? Fullname { get; set; }
    public string? Qualification { get; set; }
}
