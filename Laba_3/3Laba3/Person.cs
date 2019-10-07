using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3LABA3
{
   class Person
{
    public string name;
    public int age;
 
    public Person() { name = "NoName"; age = 1; }      
     
    public Person(int n) { name = "NoName"; age = n; }         
     
    public Person(string n, int a) { name = n; age = a; }   
     
    public void GetInfo()
    {
        Console.WriteLine("Имя: {name}  Возраст: {age}");
    }
}

}
