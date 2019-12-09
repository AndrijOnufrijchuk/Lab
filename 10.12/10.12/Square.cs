using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._12
{
    class Square<T> : Shape<T>
       where T : struct
    {
        public Square(T A) : base(A)
        {

            Console.WriteLine();
        }

        
    }
}
