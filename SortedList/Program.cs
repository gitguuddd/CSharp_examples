using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SortedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList sortedList = new SortedList();
            sortedList.Add("one", 1);
            sortedList.Add("two", 2);
            sortedList.Add("three", 3);
            sortedList.Add("four", 4);

            foreach (DictionaryEntry val in sortedList)
                Console.WriteLine($"key: {val.Key}, value: {val.Value}");
            sortedList.Remove("one");
            sortedList.RemoveAt(2);
            Console.WriteLine("sortedlist after element removal");
            foreach (DictionaryEntry val in sortedList)
                Console.WriteLine($"key: {val.Key}, value: {val.Value}");
            Console.WriteLine($"Does sortedList contain an element with a key of sixty nine ?: {sortedList.ContainsKey("sixty nine")}");

        }
    }
}
