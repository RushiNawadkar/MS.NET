using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
      public  class Student :Person
    {
        public int rollno;
        public double fees;


        public Student(int id, String Name, String Title,int rollno, double fees) :base(id,Name,Title)
        {
            this.rollno = rollno;
            this.fees = fees;
        }

        public override void showDetails()
        {
            Console.WriteLine("Id :" + Id);
            Console.WriteLine("Name :" + Name);
            Console.WriteLine("Title :" + Title);
            Console.WriteLine("rollno :" + rollno);
            Console.WriteLine("fees :" + fees);

        }
    }
}
