using System;

class Program
{
    static void Main(string[] args)
    {
        int counter = int.Parse(Console.ReadLine());

        for(int i=0; i<counter; i++)
        {
            int value = int.Parse(Console.ReadLine());
            var box = new Box<int>(value);

            Console.WriteLine(box);
        }
    }
}