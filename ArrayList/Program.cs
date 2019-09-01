using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLists
{
    class Program
    {
        static void Main(string[] args)
        {
          ArrayList arrayList1 = new ArrayList();
            arrayList1.Add(1);
            arrayList1.Add("Two");
            arrayList1.Add(4.5);

            IList arrayList2 = new ArrayList()
            {
                100,200
            };
            arrayList1.AddRange(arrayList2);
            arrayList1.InsertRange(2, arrayList2);

            var firstElement = arrayList1[0];

            arrayList1.Insert(1, "Second Item");
            foreach (var val in arrayList1)
                Console.WriteLine(val);
            arrayList1.Remove("Two");
            arrayList1.RemoveAt(1);
            arrayList1.RemoveRange(2, 2);
            Console.WriteLine("View after element removal and sorting");
            arrayList1.Sort();
            foreach (var val in arrayList1)
                Console.WriteLine(val);
            arrayList1.Reverse();
            Console.WriteLine("Descending view");
            foreach (var val in arrayList1)
                Console.WriteLine(val);
            Console.WriteLine($"Does arrayList contain \"Hello World\" ? :{arrayList1.Contains("Hello World")}");
        }
    }
}
