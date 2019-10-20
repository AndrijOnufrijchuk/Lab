using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Product
    {
        private string name;
        private float cost;

        public Product(string name, float cost)
        {
            this.Name = name;
            this.Cost = cost;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                this.name = value;
            }
        }

        public float Cost
        {
            get
            {
                return this.cost;
            }

            private set
            {
                this.cost = value;
            }
        }
    }
}
