using System;

namespace Deligates
{
    public delegate void calculate(int a, int b);
    class Program
    {
        public static void Additon(int a, int b)
        {
            int ans = a + b;
            Console.WriteLine("Additon :" + ans);

        } 
        public static void Subtraction(int a, int b)
        {
            int ans = a - b;
            Console.WriteLine("Subtraction :" + ans);

        }
        public static void Multiplication(int a, int b)
        {
            int ans = a * b;
            Console.WriteLine("Multiplication :" + ans);

        }
        public static void Division(int a, int b)
        {
            int ans = a / b;
            Console.WriteLine("Division :" + ans);

        }


        public static void Main(string[] args)
        {
            calculate obj = new calculate(Program.Additon);
            obj.Invoke(5, 6);
            
            obj += Subtraction;
            obj(50, 10);
            obj = Multiplication;
            obj(50, 10);

        }

    }
}