using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Helper
{
    class Program
    {
        static void Main(string[] args)
        {
            Array array = Array.CreateInstance(typeof(int), new int[1] { 5 }, new int[1] { 1 });
            array.SetValue(1, 1);
            array.SetValue(2, 2);
            array.SetValue(3, 3);
            array.SetValue(4, 4);
            array.SetValue(5, 5);
            foreach (int i in array)
                Console.WriteLine("Array value {0} at position {1}", array.GetValue(i), i);

        }
    }
}
