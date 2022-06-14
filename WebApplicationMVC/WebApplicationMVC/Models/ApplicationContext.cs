using Microsoft.EntityFrameworkCore;


namespace WebApplicationMVC.Models;

public class ApplicationContext : DbContext
{
    public DbSet<Class> Classes { get; set; } = null!;
    public DbSet<Learningactivity> Learningactivities { get; set; } = null!;
    public DbSet<Subject> Subjects { get; set; } = null!;
    public DbSet<Teacher> Teachers { get; set; } = null!;
    public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options) {
        Database.EnsureCreated();
    }
    public ApplicationContext() {
        Database.EnsureCreated();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }
}
