using Microsoft.EntityFrameworkCore;

namespace InspecTest.Data
{
    // DbContext for your InspecTest project
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }

        // We'll reference these external classes in separate files:
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
    }

    // Keep 'Person' definition here (or move it to Person.cs if you want)
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
