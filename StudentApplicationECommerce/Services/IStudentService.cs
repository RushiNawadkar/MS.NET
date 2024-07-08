using StudentWebApp.Models;
namespace StudentWebApp.Services
{
    public interface IStudentService
    {
        List<Students> GetStudents();
       bool insert(Students student);

        bool delete(int id);
        bool update(Students students); 
    }
}
