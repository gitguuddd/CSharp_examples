using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Student Name: ");

            string studentName = Console.ReadLine();

            try
            {
                List<String> studentList = FindAllStudentFromDatabase(studentName);

                Console.WriteLine($"Total {studentName}: {studentList.Count()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("No Students exists for the specified name.");
            }
            finally
            {
                Console.WriteLine("This text is shown no matter what happens :)");
            }

            
        }
        private static List<String> FindAllStudentFromDatabase(string StudentName)
        {
            List<String> studentList = new List<string>() { "John bon", "John tron", "John from" };

            return studentList;

        }
    }
}
