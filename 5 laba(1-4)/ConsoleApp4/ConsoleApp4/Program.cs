using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{   class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            List<Product> products = new List<Product>();
            string[] input = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string el in input)
            {
                string[] inp = el.Split('=');
                string name = inp[0].Trim();
                float money = float.Parse(inp[1].Trim());
               
                    persons.Add(new Person(name, money));
               
            }

            input = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string token in input)
            {
                string[] tok = token.Split('=');
                string name = tok[0].Trim();
                float cost = float.Parse(tok[1].Trim());
                
                    products.Add(new Product(name, cost));
            }

            string command = Console.ReadLine();

            while (command != "END")
            {
                input = command.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                string personName = input[0];
                string productName = input[1];
                Person person = persons.Where(p => p.Name == personName).First();
                Product product = products.Where(p => p.Name == productName).First();

                if (person.Money >= product.Cost)
                {
                    person.Money -= product.Cost;
                    person.addProduct(product);
                    Console.WriteLine("{0} bought {1}", person.Name, product.Name);
                }
                else
                {
                    Console.WriteLine("{0} cannot afford {1}", person.Name, product.Name);
                }

                command = Console.ReadLine();
            }

            foreach (Person person in persons)
            {
                if (person.Check().Count > 0)
                {
                    Console.WriteLine("{0} - {1}", person.Name, String.Join(",", person.Check().Select(p => p.Name)));
                }
                else
                {
                    Console.WriteLine("{0} - Nothing bought", person.Name);
                }
            }
        }
    }
}