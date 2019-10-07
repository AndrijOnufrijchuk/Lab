using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Car[] cars = new Car[count];

            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();
                string[] elements = input.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                string model = elements[0];
                int speed = int.Parse(elements[1]);
                int power = int.Parse(elements[2]);
                int weight = int.Parse(elements[3]);
                string type = elements[4];
                double tyre1Pressure = double.Parse(elements[5]);
                int tyre1Age = int.Parse(elements[6]);
                double tyre2Pressure = double.Parse(elements[7]);
                int tyre2Age = int.Parse(elements[8]);
                double tyre3Pressure = double.Parse(elements[9]);
                int tyre3Age = int.Parse(elements[10]);
                double tyre4Pressure = double.Parse(elements[11]);
                int tyre4Age = int.Parse(elements[12]);

                cars[i] = new Car(model, new Engine(speed, power), new Cargo(type, weight), new List<Tyre> { new Tyre(tyre1Pressure, tyre1Age), new Tyre(tyre2Pressure, tyre2Age), new Tyre(tyre3Pressure, tyre3Age), new Tyre(tyre4Pressure, tyre4Age) });
            }

            string input2 = Console.ReadLine();

            if (input2 == "fragile")
            {
                cars.Where(c => c.cargo.type == "fragile").Where(c => c.tires.Any(t => t.pressure < 1)).Select(c => c.model).ToList().ForEach(m => Console.WriteLine(m));
            }
            else if (input2 == "flamable")
            {
                cars.Where(c => c.cargo.type == "flamable").Where(c => c.engine.power > 250).Select(c => c.model).ToList().ForEach(m => Console.WriteLine(m));
            }
        }
    }
}