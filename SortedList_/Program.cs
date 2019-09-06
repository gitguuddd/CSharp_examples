using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SortedList_
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> sortedList1 = new SortedList<int, string>();
            sortedList1.Add(3, "Three");
            sortedList1.Add(4, "Four");
            sortedList1.Add(1, "One");
            sortedList1.Add(5, "Five");
            sortedList1.Add(2, "Two");

            foreach (KeyValuePair<int, string> kvp in sortedList1)
                Console.WriteLine($"key: {kvp.Key}, value: {kvp.Value}");

            string val;

            if (sortedList1.TryGetValue(69, out val))
                Console.WriteLine($"value: {val}");
            else
                Console.WriteLine("Key is not valid");

            if (sortedList1.TryGetValue(1, out val))
                Console.WriteLine($"value: {val} ");

            sortedList1.Remove(1);
            sortedList1.RemoveAt(0);

            Console.WriteLine("sortedList after element removal");

            foreach (KeyValuePair<int, string> kvp in sortedList1)
                Console.WriteLine($"key: {kvp.Key}, value: {kvp.Value}");

            Console.WriteLine($"Does sortedList contain a key-value pair with a key  69 ? : {sortedList1.ContainsKey(69)}");
            Console.WriteLine($"Does sortedlist contain a key-value pair with a value \"Five\"? : {sortedList1.ContainsValue("Five")} ");

            var query = from kvp in sortedList1
                        where kvp.Key == 3
                        select kvp;

            var result = query.FirstOrDefault();

            Console.WriteLine($"key: {result.Key}, value: {result.Value}");
        }
    }
}
