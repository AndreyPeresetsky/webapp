using System.ComponentModel.DataAnnotations;

namespace WebApplicationMVC.Models
{
    public class Subjects
    {
        [Key]
        public int? idsubject { get; set; }
        public string? Name { get; set; }
    }
}
