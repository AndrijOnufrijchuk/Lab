using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Person
    {
        private string name;
        private float money;
        private List<Product> bag;

        public Person(string name, float money)
        {
            this.Name = name;
            this.Money = money;
            this.bag = new List<Product>();
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

        public float Money
        {
            get
            {
                return this.money;
            }

            set
            {
                
                this.money = value;
            }
        }

        public void addProduct(Product product)
        {
            this.bag.Add(product);
        }

        public List<Product> Check()
        {
            return this.bag;
        }
    }
}
