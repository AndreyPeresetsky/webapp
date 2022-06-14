using System.ComponentModel.DataAnnotations;

namespace WebApplicationMVC.Models;

public class Learningactivity
{
    [Key]
    public int? Idlearningactivity { get; set; }
    public int? Idteacher { get; set; }
    public int? Idsubject { get; set; }
    public int? Idclass { get; set; }
}
