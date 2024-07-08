using Microsoft.EntityFrameworkCore.Diagnostics;
using StudentWebApp.Models;
using StudentWebApp.Repository;
using System.Security.Cryptography.Xml;
using System.Xml.Linq;

namespace StudentWebApp.Services
{
    public class StudentService : IStudentService
    {
        public List<Students> GetStudents()
        {
            using (var context = new DBContext())
            {
                var students = from s in context.students select s;
                
                return students.ToList<Students>();
            }
        }

        public bool insert(Students student)
        {
            using (var context = new DBContext())
            {
                context.students.Add(student);
                context.SaveChanges();
            }
            return true;
        }

        public bool delete(int id)
        {
            using (var context = new DBContext())
            {
                var find=context.students.Find(id);
                if(find != null)
                {
                    context.students.Remove(find);
                    context.SaveChanges();
                }
            }
            return true;
        }
        public bool update(Students students)
        {
            using (var context = new DBContext())
            {
                var p=context.students.Find(students.studId);
                if(p != null) 
                {
                   p.Name=students.Name;
                    p.email=students.email;
                    p.address=students.address;
                    p.status=students.status;
                    p.MobNo=students.MobNo;


                }
                context.SaveChanges();
            }

            return true;
        }


    }
}
