﻿using System;

class Program
{
    static void Main(string[] args)
    {
        int counter = int.Parse(Console.ReadLine());

        for(int i=0; i<counter; i++)
        {
            string value = Console.ReadLine();
            Box<string> box = new Box<string>(value);

            Console.WriteLine(box);
        }
    }
}