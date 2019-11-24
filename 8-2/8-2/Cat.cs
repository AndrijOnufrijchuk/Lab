using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_2
{
    public class Cat : Animal
    {
        public Cat(string name, string favouriteFood)
            : base(name, favouriteFood)
        {
        }

        public override string ExplainSelf()
        {
            var str = new StringBuilder();

            str.AppendLine(base.ExplainSelf()).Append("Myaw");

            return str.ToString();
        }
    }
}