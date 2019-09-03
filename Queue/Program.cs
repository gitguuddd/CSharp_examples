using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Queue_
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue(3);
            queue.Enqueue(2);
            queue.Enqueue(1);
            queue.Enqueue("Four");

            foreach (var val in queue.ToArray())
                Console.WriteLine(val);

            Console.WriteLine($"Top element is : {queue.Peek()}");

            Console.WriteLine($"Dequeueing elements {queue.Dequeue()} and {queue.Dequeue()}");

            Console.WriteLine($"Does queue contain an element with a value of 7? : {queue.Contains(7)}");

            Console.WriteLine($"Number of elements in the queue {queue.Count}");

            queue.Clear();

            Console.WriteLine($"Number of elements in the queue {queue.Count}");

        }
    }
}
