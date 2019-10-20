using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
          

            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            Chicken chicken = new Chicken(name, age);
                Console.WriteLine($"Chicken {chicken.Name} age {chicken.Age} make {chicken.GetProductPerDay()} eggs.");
            
           
        }
    }
}