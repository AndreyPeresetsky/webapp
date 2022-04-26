using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Pages
{
    public class IndexModel_classes : PageModel
    {
        public List<Class>? ClassList { get; private set; }

        public void OnGet()
        {
            ClassList = GetClassData.GetClassList();
        }
    }

    public class Class
    {
        [Key]
        public int Idclass { get; set; }
        public string? Name { get; set; }
    }

    static public class GetClassData
    {
        static public List<Class> GetClassList()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var classes = db.Classes.FromSqlRaw($"SELECT * FROM class;").ToList();

                Console.WriteLine("ClassList");
                foreach (var u in classes)
                {
                    Console.WriteLine(u.Idclass + " " + u.Name);
                }
                return classes;
            }
        }
    }
}
