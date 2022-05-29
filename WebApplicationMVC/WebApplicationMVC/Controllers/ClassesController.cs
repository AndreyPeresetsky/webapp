using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
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
    public List<Classes>? ClassList { get; private set; }

    public void OnGet(ApplicationContext db)
    {
        ClassList = GetClassData.GetClassList(db);
    }
}

static public class GetClassData
{
    static public List<Classes> GetClassList(ApplicationContext db)
    {
        string requestsql = $"SELECT * FROM class;";
        var classes = db.Classes.FromSqlRaw(requestsql).ToList();
        Console.WriteLine("Classes");
        foreach (var c in classes)
        {
            Console.WriteLine(c.Idclass + " " + c.Name);
        }
        return classes;
    }
}

