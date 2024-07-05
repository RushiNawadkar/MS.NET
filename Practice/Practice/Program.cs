using System;

namespace Test
{
    public class Tester
    { 
        static void passbyvalue( int a)
        {
            a=a+10;
            Console.WriteLine("pass by value :" + a);
        }
    
        static void Main(string[] args)
        {
            int a =5;
            
            passbyvalue( a);
            Console.WriteLine(a);

        }

    }
}
