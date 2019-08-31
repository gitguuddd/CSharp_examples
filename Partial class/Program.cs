using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Partial;
namespace Partial_class
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            var test = new MyPartialClass();
            test.Method1(x);
            test.Method2(x);
            test.Method3(x);//partial methods are implicitly private 
            Console.ReadLine();
        }
    }
}
