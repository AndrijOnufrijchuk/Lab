using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var boxes = new List<Box<string>>();

        int counter = int.Parse(Console.ReadLine());

        for(int i=0; i<counter; i++)
        {
            string value = Console.ReadLine();
            boxes.Add(new Box<string>(value));
        }

        int[] indx = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Swap(boxes, indx[0], indx[1]);

        foreach(var box in boxes)
        {
            Console.WriteLine(box);
        }
    }

    static void Swap<T>(IList<Box<T>> list, int index1, int index2)
    {
        Box<T> temp = list[index1];
        list[index1] = list[index2];
        list[index2] = temp;
    }
}