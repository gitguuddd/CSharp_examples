using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anon_type
{
    class Program
    {
        static void Main(string[] args)
        {
            var myAnonymousType = new
            {
                firstProperty = "First Property",
                secondProperty = 2,
                thirdProperty = true
            };
            DoSomething(myAnonymousType);
            Console.ReadLine();
        }

        static void DoSomething(dynamic param)
        {
            Console.WriteLine(param.firstProperty);
        }
    }
}
