using FirstApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
            
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course>  Courses  { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }

      
    }
}
