using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_2
{
    public class Dog : Animal
    {
        public Dog(string name, string favouriteFood)
            : base(name, favouriteFood)
        {
        }

        public override string ExplainSelf()
        {
            var builder = new StringBuilder();

            builder.AppendLine(base.ExplainSelf()).Append("Gaf");

            return builder.ToString();
        }
    }
}
