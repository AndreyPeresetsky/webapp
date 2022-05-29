using System.ComponentModel.DataAnnotations;

namespace WebApplicationMVC.Models
{
    public class Learningactivities
    {
        [Key]
        public int? idlearningactivities { get; set; }
        public int? idsubject { get; set; }
        public int? idteacher { get; set; }
        public int? idclass { get; set; }
    }
}
