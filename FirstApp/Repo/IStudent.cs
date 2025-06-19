using FirstApp.Models;

namespace FirstApp.Repo
{
    public interface IStudent
    {
        IEnumerable<Student> GetAll();

        Student GetStudent(int id);

       void Create(Student student);
    }
}
