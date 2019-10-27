using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string author = Console.ReadLine();
                string title = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());

                Book book = new Book(author, title, price);
                GoldenEditionBook gb= new GoldenEditionBook(author, title, price);

                Console.WriteLine(book);
                Console.WriteLine(gb);
                Console.ReadLine();
            }
            catch (ArgumentException err)
            {
                Console.WriteLine(err.Message);
                Console.ReadLine();
            }

        }
    }
}