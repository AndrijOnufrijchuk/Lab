using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Program
{
    static void Main(string[] args)
    {
        //1program
        //Console.Write("Enter ur name ");
        //String strangerName = Console.ReadLine();
        //Console.WriteLine($"Hi , {strangerName}");

        //2 
        /*  int a, b, c;
        Console.Write("Enter first number ");
        a = Convert.ToInt32( Console.ReadLine());
        Console.Write("Enter second number ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter third number ");
        c = Convert.ToInt32(Console.ReadLine());
        float average;
        average = (a + b + c) / 3;
        Console.WriteLine(average);
        */



        /*
         * third program
        float a, b, h, area ;

        Console.Write("Enter a");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter b");
        b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter h");
        h = Convert.ToInt32(Console.ReadLine());

        area = (a + b) / 2 *h;
        Console.WriteLine(area);
        */

        /*
         * 4 program
        int n, lastdigit;
        Console.Write("Enter n");
        n = Convert.ToInt32(Console.ReadLine());
        lastdigit = n % 10;

        Console.WriteLine(lastdigit);
        */
        /*
        int n, number, nDigit;
        Console.Write("Enter number");
        number = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter n");
        n = Convert.ToInt32(Console.ReadLine());
        nDigit = (number / 10 ^ (n - 1)) % 10;
        Console.WriteLine(nDigit);
       */


        /*
         * Working
        int  number;
        Console.Write("Enter number");
        number = Convert.ToInt32(Console.ReadLine());

        if(number>20 && number % 2 != 0)
        {
            Console.WriteLine($"(number) is greater than 20 and odd ");
        }
        else
        {
            Console.WriteLine($"(number) is not greater than 20 or odd ");
        }
        */
        /*allgood
        int number;
        Console.Write("Enter number");
        number = Convert.ToInt32(Console.ReadLine());
        if (number%9 == 0 && number%11 == 0 && number % 13 == 0)
        {
            Console.WriteLine("Working");
        }
    */
        /*
            int a, b, c;

            Console.Write("Enter  1 number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter  2 number");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter  3 number");
            c = Convert.ToInt32(Console.ReadLine());

            int biggest=0;
            if (a > b && a > c)
                biggest = a;
            if (b > a && b > c)
                biggest = b;
            if (c > a && c > b)
                biggest = c;
            Console.WriteLine(biggest);
        */
       /*
        int number;
        Console.Write("Enter  ");
        number = Convert.ToInt32(Console.ReadLine());

        if(number > 7 && number<0)
        {
            Console.WriteLine("Eror");
        }
        switch (number)
        {
            case 1:
                Console.WriteLine("Monday");
                break;

            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;

            case 4:
                Console.WriteLine("Thursday");
                break;

            case 5:
                Console.WriteLine("Friday");
                break;

            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Not valid");
                break;
        }
      */

        /*
         * 
         */

        /* WE HAVE DONE POG
        int a, b, c, product=0;
        Console.Write("Enter a ");
        a = Convert.ToInt32(Console.ReadLine());
        if (a < 0)
        {
            product++;
        }
    
        Console.Write("Enter b ");
        b = Convert.ToInt32(Console.ReadLine());
        if (b < 0)
        {
            product+=1;
        }
        Console.Write("Enter c ");
        c = Convert.ToInt32(Console.ReadLine());
        if (c < 0)
        {
            product+=1;
        }

        switch (product)
        {
            case 0:
                Console.WriteLine("Positive");
                break;
            case 1:
                Console.WriteLine("Negative");
                break;
            case 2:
                Console.WriteLine("Positive");
                break;

            case 3:
                Console.WriteLine("Negative");
                break;


        }
        */
        /*
         * DONT WRITE BIG NUMBERS
        int n, factorial=1;

        Console.Write("Enter n ");
        n = Convert.ToInt32(Console.ReadLine());
        for(int i=2; i<=n; i++)
        {
            factorial *= i;
        }
        Console.WriteLine(factorial);

        */

    }
}

