using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_15
{
    class Program
    {
       static void Main(string[] args)
       {
           string input = Console.ReadLine();

           if (input == "square")
{
                int size = int.Parse(Console.ReadLine());
                CreateEl cor = new CreateEl(new Square(size));
                cor.square.Create();
           }
           else if (input == "rectangle")
           {
                int width = int.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                CreateEl cor = new CreateEl(new Rectangle(width, height));
                cor.rectangle.Create();
           }
       }
   }
}