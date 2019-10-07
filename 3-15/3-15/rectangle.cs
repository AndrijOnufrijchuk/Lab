using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_15
{
    public class Rectangle
    {
        public int width;
        public int height;

        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public void Create()
        {
            for (int i = 0; i < this.height; i++)
            {
                if (i == 0 || i == this.height - 1)
                {
                    Console.WriteLine("|" + new string('-', this.width) + "|");
                }
                else
                {
                    Console.WriteLine("|" + new string(' ', this.width) + "|");
                }
            }
        }
    }
}