namespace FirstApp.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Enrolled { get; set; }
        public ICollection<StudentCourse> Enrollment { get; set; }
    }
}
