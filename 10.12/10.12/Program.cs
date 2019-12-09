using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._12
{
    class Program
    {
        static void Main(string[] args)
        {

            Shape<int> ccc = new Shape<int>(11);
            Round<int> c = new Round<int>(11);
            Square<int> cc = new Square<int>(11);
            Console.WriteLine(ccc.CalculateArea());

        }
    }
}
