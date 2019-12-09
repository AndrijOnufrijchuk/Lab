using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._12
{
    class Shape<T>
    {



        public T A { get; private set; }
        public Shape(T a)
        {
            A = a;
        }

        public T CalculateArea()
        {
            
            return A;
        }
        public struct Coords
        {
            public int x, y;

            public Coords(int p1, int p2)
            {
                x = p1;
                y = p2;
            }
        }

    }
}


