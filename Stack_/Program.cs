using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Stack_
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack();
            myStack.Push("Hello!");
            myStack.Push(null);
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);

            foreach (var itm in myStack)
                Console.WriteLine(itm);

            Console.WriteLine($" The current top element is :{myStack.Peek()}");

            Console.WriteLine($"Number of elements in the stack: {myStack.Count}");

            myStack.Pop();
            myStack.Pop();
            myStack.Pop();

            Console.WriteLine($"Number of elements in the stack: {myStack.Count}");

            Console.WriteLine($"Does stack contain a null element ? :{myStack.Contains(null)}");

            myStack.Clear();

            Console.WriteLine($"Number of elements in the stack: {myStack.Count}");
        }
    }
}
