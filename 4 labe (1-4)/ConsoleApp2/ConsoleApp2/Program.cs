using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            float length = float.Parse(Console.ReadLine());
            float width = float.Parse(Console.ReadLine());
            float height = float.Parse(Console.ReadLine());

            Box box = new Box(length, width, height);

            Console.WriteLine("Surface " + box.getSurfacearea());
            Console.WriteLine("Lateral Surface -" + box.getLateralSurfaceArea());
            Console.WriteLine("Volume - "+ box.getVolume());
        }
    }
}
