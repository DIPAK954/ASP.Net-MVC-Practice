using FirstApp.Data;
using FirstApp.Models;

namespace FirstApp.Repo
{
    public class StudentRepo : IStudent
    {
        private readonly DataContext _context;

        public StudentRepo(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<Student> GetAll()
        {
            return _context.Students.ToList();
        }

        public Student GetStudent(int id)
        {
            return _context.Students.Where(x => x.ID == id).FirstOrDefault();
        }

        public void Create(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }
    }
}
