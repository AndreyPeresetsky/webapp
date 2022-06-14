using System.ComponentModel.DataAnnotations;

namespace WebApplicationMVC.Models;

public class Subject
{
    [Key]
    public int Idsubject { get; set; }
    public string? Name { get; set; }
}
