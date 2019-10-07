using System;
 
namespace first

{
    class Person
    {
        public string Name; 
        public int Age;
        private string name;
        private int age;
        public void info()
        {

            Console.WriteLine("Имя: "+Name +" Возраст:"+ Age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person Andrij;
           
            Console.Read();
        }
    }
}