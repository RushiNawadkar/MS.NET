using System;

namespace AnynomusClass
{
    public delegate void MyMethod(int num);

    class Program
    {
        static void Main(string[] args)
        {
            MyMethod obj = delegate (int a)
            {
                a += 5;
                Console.WriteLine(a);
            };

            obj.Invoke(5);

        }
    }
}
