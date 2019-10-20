using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Box

    {

        private float length;
        private float width;
        private float height;

        public Box(float length, float width, float height)
        {
            this.Length =length;
            this.Width = width;
            this.Height = height;
        }
        public float Length{

            get { return length; }

            set {
                if (value <= 0) 
                {
                    Console.WriteLine("Value cannot be less than 0");
                           
                }
                
                length = value; }

        }
        public float Width
        {

            get { return width; }

            set {
                if (value <= 0)
                {
                    Console.WriteLine("Value cannot be less than 0");

                }
                width = value; }

        }
        public float Height
        {

            get { return height; }

            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Value cannot be less than 0");

                }
                height = value; }

        }

        public double getVolume()
        {
            return this.Length * this.Width * this.Height;
        }

        public double getLateralSurfaceArea()
        {
            return this.Length * this.Height * 2 + this.Width * this.Height * 2;
        }

        public double getSurfacearea()
        {
            return 2 * this.Length * this.Width + 2 * this.Length * this.Height + 2 * this.Width * this.Height;
        }


    }

}
