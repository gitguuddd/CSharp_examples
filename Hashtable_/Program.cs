using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Hashtable_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cannot add duplicate keys
            Hashtable ht = new Hashtable();

            ht.Add(1, "One");
            ht.Add(2, "Two");
            ht.Add(3, "Three");
            ht.Add("Fv", "Five");
            ht.Add(8.5F, 8.5);

            foreach (DictionaryEntry val in ht)
                Console.WriteLine($"key: {val.Key}, value: {val.Value}");

            Console.WriteLine("Iterating through keys");

            foreach (var key in ht.Keys)
                Console.WriteLine($"{key}");

            Console.WriteLine("Iterating through values");

            foreach (var value in ht.Values)
                Console.WriteLine($"{value}");

            Console.WriteLine("Hashtable after element removal");

            ht.Remove(8.5F);

            foreach (DictionaryEntry val in ht)
                Console.WriteLine($"key: {val.Key}, value: {val.Value}");

            Console.WriteLine($"Does hashtable contain a pair with a value of \"one\"?: {ht.ContainsValue("One")}");
            ht.Clear();
        }
    }
}
