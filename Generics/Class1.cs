using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class MyGenericClass<T>
    {
        private T genericMemberVariable;

        public MyGenericClass()
        {
            
        }
        public MyGenericClass(T value)
        {
            genericMemberVariable = value;
        }

        public T genericMethod(T genericParameter)
        {
            Console.WriteLine($"Parameter type: {typeof(T).ToString()}, value: {genericParameter}");
            Console.WriteLine($"Return type: {typeof(T).ToString()}, value: {genericMemberVariable}");

            return genericMemberVariable;
        }

        public T genericProperty { get; set; }
    }
}
