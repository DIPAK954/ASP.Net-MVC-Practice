using System.Security.Principal;

namespace FirstApp.Models
{
    public class Course
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public ICollection<StudentCourse> Enrollment { get; set; }
    }
}
