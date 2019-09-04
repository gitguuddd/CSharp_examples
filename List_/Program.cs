using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace List_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>();
            intList.Add(10);
            intList.Add(20);
            intList.Add(30);
            intList.Add(40);

            intList.ForEach(el => Console.WriteLine(el));

            Console.WriteLine($"Total elements: {intList.Count}");

            intList.Insert(1, 11);

            intList.Remove(10);
            intList.RemoveAt(2);

            Console.WriteLine("List elements after insertion and removal");

            foreach (var el in intList)
                Console.WriteLine(el);

            Console.WriteLine($"Does list contain only even numbers ?: {intList.TrueForAll(el => el % 2 == 0)}");
        }
    }
}
