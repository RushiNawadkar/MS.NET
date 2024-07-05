using System;
namespace Interface
{
    interface i1
    {
        void print();
    }
    interface i2
    {
        void print1();
    }
    interface i3 : i1, i2
    {
        void print2();
    }
    class Program:i3
    {
        public void print()
        {
            Console.WriteLine("This is Print 1");
        }
        public void print1()
        {
            Console.WriteLine("This is Print 2");
        }
        public void print2()
        {
            Console.WriteLine("This is Print 3");
        }


        static void Main(string[] args)
        {
            i3 myiterface=new Program();
            myiterface.print();
            myiterface.print2 ();
            myiterface.print1 ();


        }
    }
}

