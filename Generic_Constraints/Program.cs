using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Constraints
{
    class Program
    {   /*
        where T : class	Type must be reference type.
        where T: struct	Type must be value type.
        where T: new()	Type must have public parameterless constructor.
        where T: <base class name>	Type must be or derive from the specified base class
        where T: <interface name>	Type must be or implement the specified interface.
        where T: U	Type supplied for T must be or derive from the argument supplied for U.
        */
        static void Main(string[] args)
        {
            MyGenericClass<string,int> strGenericClass = new MyGenericClass<string,int>("Hello World");
            string str = "Wow";
            int a = 10;
            strGenericClass.genericMethod<int>(str, a);
            //MyGenericClass<int> intGenericClass = new MyGenericClass<int>;  - Compile time error because of the constraints
        }
    }
}
