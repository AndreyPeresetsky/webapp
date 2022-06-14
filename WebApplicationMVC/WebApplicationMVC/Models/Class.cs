using System.ComponentModel.DataAnnotations;

namespace WebApplicationMVC.Models;

public class Class
{
    [Key]
    public int Idclass { get; set; }
    public string? Name { get; set; }
}
