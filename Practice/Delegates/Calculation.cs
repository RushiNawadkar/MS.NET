using System;
namespace Delegates
{
    public delegate void cal(int a, int b);
    public static class Calculation
    {
        public static void  addition(int a,int b)
        {
            int ans= a+b;
            Console.WriteLine("addition :"+ans);
        }
        public static void Subtraction(int a, int b)
        {
            int ans = a - b;
            Console.WriteLine("Subtracion :" +ans);
        }
        public static void Divide(int a, int b)
        {

            int ans = a / b;
            Console.WriteLine("Divide "+ ans);
        }
        public static void Multiplication(int a, int b)
        {
            int ans = a * b;
            Console.WriteLine("Multiplication "+ans);
        }

    }
}
