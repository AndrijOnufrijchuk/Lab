using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                string driver = Console.ReadLine();
                var ferrari = new Ferrari(driver);
                Console.WriteLine(ferrari);
                Console.ReadLine();
            }
        }
    }
}
