using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    class Program
    {
        public class MyNormalClass
        {
            public static int ID = 0;
            public static int MethodCalled = 0;
            static MyNormalClass()
            {
                Console.WriteLine("First object instantiated");
            }
            public MyNormalClass()
            {
                Console.WriteLine("{0} object/s of MyNormalClass created so far", ++ID);
            }
            public static void MyStaticMethod()
            {
                Console.WriteLine("This is a static method which has been called {0} times",++MethodCalled);
            }
        }
        
        public static class MyStaticClass
        {
            public static int MyStaticProperty { get; set; }
            static MyStaticClass()
            {
                Console.WriteLine("Static class accessed for the first time");
            }
        }
        static void Main(string[] args)
        {
            var test1 = new MyNormalClass();
            var test2 = new MyNormalClass();
            var test3 = new MyNormalClass();
            MyNormalClass.MyStaticMethod();
            MyNormalClass.MyStaticMethod();
            MyNormalClass.MyStaticMethod();
            MyStaticClass.MyStaticProperty = 100;
            MyStaticClass.MyStaticProperty = 200;
            Console.WriteLine(MyStaticClass.MyStaticProperty);
            Console.ReadLine();
        }
    }
}
