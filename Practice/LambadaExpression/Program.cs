using System;
namespace LambdaExpression
{
    public delegate void MyMethod(int a);

    class Program
    {
        static void Main(string[] args)
        {
            MyMethod obj = (a) =>
            {
                a += 5;
                Console.WriteLine(a);

            };

            obj.Invoke(5);
            
        }
    }
}
