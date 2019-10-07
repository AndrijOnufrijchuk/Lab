using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3LABA2
{
   class Person
{
    public string name;
    public int age;
 
    public Person() { name = "NoName"; age = 1; }      // 1 конструктор
     
    public Person(int n) { name = "NoName"; age = n; }         // 2 конструктор
     
    public Person(string n, int a) { name = n; age = a; }   // 3 конструктор
     
    public void GetInfo()
    {
        Console.WriteLine("Имя: {name}  Возраст: {age}");
    }
}

}
