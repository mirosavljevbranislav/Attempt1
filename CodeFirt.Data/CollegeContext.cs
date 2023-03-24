using CodeFirt.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirt.Data
{
    public class CollegeContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Subject> Subject { get; set; }
        public DbSet<SubjectStudent> SubjectStudent { get; set; }

        public CollegeContext(DbContextOptions options) : base(options)
        {

        }



    }
}
