using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplicationMVC.Models;

namespace WebApplicationMVC.Controllers;

public class ClassesController : Controller
{
    ApplicationContext db;
    public ClassesController(ApplicationContext context)
    {
        db = context;
    }
    public IActionResult Classes()
    {
        IndexModel_classes Model = new();
        Model.OnGet(db);
        return View(Model);
    }
}
public class IndexModel_classes : PageModel
{
    public List<Class>? ClassList { get; private set; }

    public void OnGet(ApplicationContext db)
    {
        ClassList = GetClassData.GetClassList(db);
    }
}

static public class GetClassData
{
    static public List<Class> GetClassList(ApplicationContext db)
    {
        List<Class> classes = db.Classes.ToList();
        {
            Console.WriteLine("\nClasses:");
            foreach (var c in classes)
                Console.WriteLine(c.Idclass + " " + c.Name);
            Console.WriteLine();
        }
        return classes;
    }
}

