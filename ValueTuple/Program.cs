using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTuple
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = (1, "Bill", "Gates");

            (int Id, string Firstname, string Lastname) person1 = (1, "Bill", "Gates");
            DisplayTuple(person);
            DisplayTuple(person1);
            (var Personid, var FName, var Lname)  = GetPerson();
            var person2 = (Personid, FName, Lname);
            DisplayTuple(person2);

        }
        static void DisplayTuple((int, string, string) person)
        {
            Console.WriteLine($"Id = {person.Item1}");
            Console.WriteLine($"First name= {person.Item2}");
            Console.WriteLine($"Id = {person.Item3}");
        }
        static (int, string, string) GetPerson()
        {
            return ( 1,  "Bill", "Gates");
        }
    }
}
