using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] arr = input.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
            string firstName = arr[0];
            string lastName = arr[1];
            string facultyNumber = arr[2];
            Student student;
            try
            {
                student = new Student(firstName, lastName, facultyNumber);
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return;
            }

            input = Console.ReadLine();
            arr = input.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
            firstName = arr[0];
            lastName = arr[1];
            double weekSalary = double.Parse(arr[2]);
            double hoursPerDay = double.Parse(arr[3]);
            Worker worker;
            try
            {
                worker = new Worker(firstName, lastName, weekSalary, hoursPerDay);
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                Console.ReadKey();
                return;
            }

            Console.WriteLine(student);
            Console.WriteLine();
            Console.WriteLine(worker);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}