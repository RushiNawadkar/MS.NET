using System;
namespace AbstractClass
{
    abstract class Person
    {
        public String FName;
        public String LName;
        public int Age;
        public int phone;

        public abstract void printdetail();
    }

    class Student:Person
    {
        public int rollno;
        public int fees;

        public override void printdetail()
        {
            String name=this.FName+" "+this.LName;
            Console.WriteLine("Student Name {0} "+name);
            Console.WriteLine("Student age {0}" + Age);
            Console.WriteLine("Student Phone {0}" + phone);
            Console.WriteLine("Student rollno {0}" + rollno);
            Console.WriteLine("Student fees {0}" + fees);
        }

       
    }

    class Program
    {

        static void Main(string[] args)
        {
            Student std = new Student();
            std.FName = "ramu";
            std.LName = "patil";
            std.Age = 15;
            std.fees = 252;
            std.phone = 2335454;
            std.rollno = 169;
           
        }

    }


}
