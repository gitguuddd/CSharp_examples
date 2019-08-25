using System;

namespace Implicit_Var
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 10;
            Console.WriteLine("Type of i is {0}", i.GetType().ToString());
            var str = "Hello World!!";
            Console.WriteLine("Type of str is {0}", str.GetType().ToString());
            var d = 100.50d;
            Console.WriteLine("Type of d is {0}", d.GetType().ToString());
            var b = true;
            Console.WriteLine("Type of b is {0}", b.GetType().ToString());
            Console.ReadLine();
        }
    }
}
