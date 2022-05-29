using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
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
    public List<Teachers>? TeacherList { get; private set; }
    public List<Subjects>? SubjectList { get; private set; }
    public List<Classes>? ClassList { get; private set; }

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
    static public List<Teachers> GetTeacherList(ApplicationContext db)
    {

        var teachers = db.Teachers.FromSqlRaw($"SELECT * FROM teacher;").ToList();
        Console.WriteLine("Teachers:");
        foreach (var t in teachers)
            Console.WriteLine(t.idteacher + " " + t.Fullname);
        return teachers;
    }
    static public List<Subjects> GetSubjectList(ApplicationContext db, int? id)
    {

        string requestsql = $"select distinct subject.idsubject, name from subject join (select distinct * from learningactivities join teacher on teacher.idteacher = learningactivities.idteacher where teacher.idteacher = {id}) t on subject.idsubject = t.idsubject;";
        var subjects = db.Subjects.FromSqlRaw(requestsql).ToList();
        Console.WriteLine("subjects:");
        foreach (var s in subjects)
            Console.WriteLine(s.idsubject + " " + s.Name);
        return subjects;
        
    }

    static public List<Classes> GetClassList(ApplicationContext db, int? id)
    {
        string requestsql = $"select distinct class.idclass, name from class join (select distinct * from learningactivities join teacher on teacher.idteacher = learningactivities.idteacher where teacher.idteacher = {id}) t on class.idclass = t.idclass;";
        var classes = db.Classes.FromSqlRaw(requestsql).ToList();
        Console.WriteLine("Classes");
        foreach (var c in classes)
            Console.WriteLine(c.Idclass + " " + c.Name);
        return classes; 
    }
}
