using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_15
{
    class CreateEl
    {
        public Rectangle rectangle;
        public Square square;

        public CreateEl(Rectangle rectangle)
        {
            this.rectangle = rectangle;
        }

        public CreateEl(Square square)
        {
            this.square = square;
        }
    }
}