using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Dictionary_
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<int, string> dict = new Dictionary<int, string>();

            dict.Add(new KeyValuePair<int, string>(1, "One"));
            dict.Add(new KeyValuePair<int, string>(2, "Two"));

            dict.Add(3, "Three");

            foreach(KeyValuePair<int, string> item in dict)
            {
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            }

            string result;

            if (dict.TryGetValue(4, out result))
            {
                Console.WriteLine(result);
            }
            else
            { Console.WriteLine("Could not find the specified key"); }

            Console.WriteLine($"Does dictionary contain a pair with a key 1 ?: {dict.ContainsKey(1)} ");

            dict.Remove(1);

            Console.WriteLine("Dictionary after element removal");
            foreach (KeyValuePair<int, string> item in dict)
            {
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            }

        }
    }
}
