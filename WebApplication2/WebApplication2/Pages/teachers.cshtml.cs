using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;


namespace WebApplication2.Pages
{
    public class IndexModel_teachers : PageModel
    {
        public List<Teacher>? TeacherList { get; private set; }
        public List<Subject>? SubjectList { get; private set; }
        public List<Class>? ClassList { get; private set; }

        public void OnGet(int? id = null)
        {
            if (id is int){
                Console.WriteLine();
                SubjectList = GetTeachersData.GetSubjectList(id);
                ClassList = GetTeachersData.GetClassList(id);
            }
            else{
                TeacherList = GetTeachersData.GetTeacherList();
                }
        }
    }



    public class Teacher
    {
        [Key]
        public int idteacher { get; set; }
        public string? Fullname { get; set; }
    }

    public class Subject
    {
        [Key]
        public int? idsubject { get; set; }
        public string? Name { get; set; }
    }
    public class ConfDB
    {
        public string? Host { get; set; }
        public string? Port { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
    }


    public class Learningactivities
    {
        [Key]
        public int? idlearningactivities  { get; set; }
        public int? idsubject { get; set; }
        public int? idteacher { get; set; }
        public int? idclass { get; set; }
    }
    public class ApplicationContext : DbContext
    {
        public DbSet<Teacher> Teachers { get; set; } = null!;
        public DbSet<Class> Classes { get; set; } = null!;
        public DbSet<Subject> Subjects { get; set; } = null!;

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Username=postgres;Password=1337");
        }
    }

    static public class GetTeachersData
    {
        static public string Get(int request)
        {
            return request.ToString();
        }
        static public List<Teacher> GetTeacherList()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var teachers = db.Teachers.FromSqlRaw($"SELECT * FROM teacher;").ToList();
                Console.WriteLine("Teachers:");
                foreach (var t in teachers)
                {
                    Console.WriteLine(t.idteacher + " " + t.Fullname);
                }
                return teachers;
            }
        }

        static public List<Subject> GetSubjectList(int? id)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                string requestsql = $"select distinct subject.idsubject, name from subject join (select distinct * from learningactivities join teacher on teacher.idteacher = learningactivities.idteacher where teacher.idteacher = {id}) t on subject.idsubject = t.idsubject;";
                var subjects = db.Subjects.FromSqlRaw(requestsql).ToList();

                Console.WriteLine("subjects:");
                foreach (var s in subjects)
                {
                    Console.WriteLine(s.idsubject + " " + s.Name);
                }

                return subjects;
            }
        }

        static public List<Class> GetClassList(int? id)
        {
            using (ApplicationContext db = new ApplicationContext())
            {

                string requestsql = $"select distinct class.idclass, name from class join (select distinct * from learningactivities join teacher on teacher.idteacher = learningactivities.idteacher where teacher.idteacher = {id}) t on class.idclass = t.idclass;";
                var classes = db.Classes.FromSqlRaw(requestsql).ToList();
                Console.WriteLine("Classes");
                foreach (var c in classes)
                {
                    Console.WriteLine(c.Idclass + " " + c.Name);
                }
                return classes;
            }
        }
    }
}
