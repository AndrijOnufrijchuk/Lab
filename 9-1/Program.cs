using System;

class Program
{
    static void Main(string[] args)
    {
        var box1 = new Box<int>(123);
        var box2 = new Box<string>("TextText");

        Console.WriteLine(box1);
        Console.WriteLine(box2);
    }
}