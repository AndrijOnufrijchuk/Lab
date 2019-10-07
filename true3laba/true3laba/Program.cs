using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace true3laba
{

    class Person {
        public int age = 1;
        public string name = "Andrusha";
        public void GetInfo() {
            Console.WriteLine(name + age + 's');
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Person Andrusha = new Person();
            Andrusha.GetInfo();
            Console.ReadKey();

        }
    }
}
