using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplicationMVC.Models;

namespace WebApplicationMVC.Controllers;

public class TeachersController : Controller
{
    ApplicationContext db;
    public TeachersController(ApplicationContext context)
    {
        db = context;
    }
    public IActionResult Teachers(int? id = null)
    {
        IndexModel_teachers Model = new();
        Model.OnGet(db, id);
        return View(Model);
    }
}
public class IndexModel_teachers : PageModel
{
    public List<Teacher>? TeacherList { get; private set; }
    public List<Subject>? SubjectList { get; private set; }
    public List<Class>? ClassList { get; private set; }

    public void OnGet(ApplicationContext db, int? id = null)
    {
        if (id is int)
        {
            ClassList = GetTeachersData.GetClassList(db, id);
            SubjectList = GetTeachersData.GetSubjectList(db, id);
        }
        else
        {
            TeacherList = GetTeachersData.GetTeacherList(db);
        }
    }
}

static public class GetTeachersData
{
    static public string Get(int request)
    {
        return request.ToString();
    }
    static public List<Teacher> GetTeacherList(ApplicationContext db)
    {

        var teachers = db.Teachers.ToList();
        {
            Console.WriteLine("Teachers:");
            foreach (var t in teachers)
                Console.WriteLine(t.Idteacher + " " + t.Fullname);
        }
        return teachers;
    }
    static public List<Subject> GetSubjectList(ApplicationContext db, int? id)
    {
        var subjects = (from c in db.Subjects
                        join l in db.Learningactivities on c.Idsubject equals l.Idsubject
                        join t in db.Teachers on l.Idteacher equals t.Idteacher
                        where t.Idteacher == id
                        orderby c
                        select c).Distinct().ToList();
        {
            Console.WriteLine("Subjects:");
            foreach (var s in subjects)
                Console.WriteLine(s.Idsubject + " " + s.Name);
        }
        return subjects;        
    }

    static public List<Class> GetClassList(ApplicationContext db, int? id)
    { 
        var classes = (from c in db.Classes
                       join l in db.Learningactivities on c.Idclass equals l.Idclass
                       join t in db.Teachers on l.Idteacher equals t.Idteacher
                       where t.Idteacher == id
                       orderby c
                       select c).Distinct().ToList();
        Console.WriteLine("Classes");
        foreach (var c in classes)
            Console.WriteLine(c.Idclass + " " + c.Name);
        return classes; 
    }
}
