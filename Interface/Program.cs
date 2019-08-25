using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface IPen
    {
        string Color { get; set; }
        string Brand { get; set; }
        bool Open();
        bool Close();
        void Write(string text);
    }
    interface IBrandedPen:IPen
    {
        string GetBrandName();
    }
    class Cello : IBrandedPen
    {
        public string Color { get; set; }

        public string Brand { get; set; }

        private bool isOpen = false;

        public bool Close()
        {
            isOpen = false;
            Console.WriteLine("Cello closed for writing!");

            return isOpen;
        }

        public bool Open()
        {
            isOpen = true;
            Console.WriteLine("Cello open for writing!");

            return isOpen;
        }

        public void Write(string text)
        {
            if (isOpen)
                Console.WriteLine("Cello: " + text);
        }

        public string GetBrandName()
        {
            return Brand;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var pen = new Cello();
            pen.Open();
            pen.Write("I am groot");
            pen.Close();
            Console.ReadLine();

        }
    }
}
