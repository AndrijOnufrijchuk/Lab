using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._12
{
    class Round<T> : Shape<T>
        where T : struct
    {
        public Round(T A) : base(A)
        {
            Console.WriteLine(A);
        }

    }
}
