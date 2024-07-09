using OnlineStudentPortal.Entity;

namespace OnlineStudentPortal.Services
{
    public interface IStudentService
    {
        List<Student> GetAll();

        bool insert(Student student);
        bool update(Student student);
        bool delete(int id);
        Student find(int id);
        
        List<Student> findAll(String status);
    }
}
