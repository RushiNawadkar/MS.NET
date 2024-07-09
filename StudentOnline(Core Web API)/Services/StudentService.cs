using OnlineStudentPortal.Entity;
using OnlineStudentPortal.Repository;

namespace OnlineStudentPortal.Services
{
    public class StudentService : IStudentService
    {
       public List<Student> GetAll()
        {
            using (var context = new StoreContext())
            {
                var p=from s in context.students select s;
                return p.ToList<Student>();
            }
        }

        public bool insert(Student student)
        {
            using (var context = new StoreContext())
            {
                context.students.Add(student);
                context.SaveChanges();
            }
           return true;

        }

        public bool update(Student student)
        {
            using (var context = new StoreContext())
            {
                var p= context.students.Find(student.studId);
                if (p != null)
                {
                    p.Name = student.Name;
                    p.email = student.email;
                    p.address= student.address;
                    p.fees = student.fees;
                    p.status = student.status;
                    p.MobNo = student.MobNo;
                    context.students.Update(p);
                    context.SaveChanges();

                }
                
            }
            return true;
        }

        public bool delete(int id)
        {
            using (var context = new StoreContext())
            {
                var p = context.students.Find(id);
                    if(p != null)
                {
                    context.students.Remove(p);
                    context.SaveChanges();
                }
            }
            return true;
        }

        public Student find(int id)
        {
            using(var context = new StoreContext())
            {
                var p = context.students.Find(id);
                return p;
                 
            }     
        }

        public List<Student> findAll(String status)
        {
            using (var context = new StoreContext())
            {
                var p = context.students.Where(e=>e.status==status);
                return p.ToList<Student>();

            }
        }

    }
}
