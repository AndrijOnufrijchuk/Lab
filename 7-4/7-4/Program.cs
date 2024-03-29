﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            string[] urls = Console.ReadLine().Split();

            Smartphone smartphone = new Smartphone();

            foreach (var number in numbers)
            {
                Console.WriteLine(smartphone.Call(number));
                
            }
            
            foreach (var url in urls)
            {
                Console.WriteLine(smartphone.Browse(url));
                Console.WriteLine();
                
            }
            Console.ReadLine();
        }

    }
}