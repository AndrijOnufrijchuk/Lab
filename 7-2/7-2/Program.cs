using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string id = Console.ReadLine();
            string birthdate = Console.ReadLine();
            Identify identifiable = new Citizen(name, age, id, birthdate);
            IBirth birthable = new Citizen(name, age, id, birthdate);
            Console.WriteLine(identifiable.Id);
            Console.WriteLine(birthable.BirthDate);
            Console.ReadLine();
        }
    }

}
