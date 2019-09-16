using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class RotateandSumm {
        static int[] Shifter(int[] arr, int k)
        {
            k++;
            int[,] res = new int[k, arr.Length];

            for (int times = 0; times < k; times++)
            {

                for (int i = 0; i < arr.Length; i++)
                {
                    if (i - times < 0)
                    {
                        res[times, i] = arr[arr.Length - times + i];
                    }
                    else
                    {
                        res[times, i] = arr[i - times];
                    }
                }

            }
            int[] sum = new int[arr.Length];
            for (int j = 0; j < sum.Length; j++)
            {
                for (int i = 0; i < k; i++)
                {
                    sum[j] += res[i, j];
                }
            }

            return sum;
        }

        public RotateandSumm()
        {
            Console.WriteLine("Start entering array of 5");
            int k;
            int[] array = new int[5];
            for (int i = 0; i < array.Length; i++)
            {

                array[i] = int.Parse(Console.ReadLine());

            }
            Console.Write(" Enter k ");
            k = Convert.ToInt32(Console.ReadLine());
            int[] res = Shifter(array, k);
            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine(res[i]);
            }
        }
    }

    class FoldandSumm {
        public FoldandSumm() {
            int k,o=0,p=0;
            Console.Write(" Enter k ");
            k = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[4*k];
            for (int i = 0; i < array.Length; i++)
            {

                array[i] = int.Parse(Console.ReadLine());

            }
            
            int[] array2 = new int[array.Length/2];
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = array[i];
                 o += array2[i];
            }
            int[] array3 = new int[array.Length / 2];
            for (int i = 0; i < array3.Length; i++)
            {
                array3[i] = array[ i + array.Length/2];
                p += array3[i];
            }

            Console.WriteLine(o+" "+p);



        }

    }
    
    
     class SieveOfEratosthenes {
         public SieveOfEratosthenes()
         {

             int n=0, i, m = 0;
             Console.Write("Enter number");
             n = int.Parse(Console.ReadLine());

             m = n / 2;
             for( ;n>2;n--){    
             for (i = 2; i <= m; i++)
                 {

                     if (n % i == 0)
                     {

                         return;
                     }
                     else {
                         Console.WriteLine(n);
                     }
                  }
         }


     }
     }

     class CompareCharArrays
     {
         public CompareCharArrays()
         {


             int k;
             Console.Write(" Enter k ");
             k = Convert.ToInt32(Console.ReadLine());
                   
             char[] array = new char[k];
             for (int i = 0; i < array.Length; i++)
             {

                 array[i] = Console.ReadKey().KeyChar;

             }
             Console.WriteLine("");

             

            int c;   
             Console.Write(" Enter c ");
             c = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("");
             char[] array2 = new char[c];
             for (int i = 0; i < array2.Length; i++)
             {

                 array2[i] = Console.ReadKey().KeyChar;

             }
             Console.WriteLine("");

             
             byte[] ASCIIValues = Encoding.ASCII.GetBytes(array);
             byte[] ASCIIValues2 = Encoding.ASCII.GetBytes(array2);

             foreach (char q in array)
             {
               

                 foreach (char z in array2)
                 {

                     if ((int)z > (int)q)
                     {
                         Console.WriteLine(array);
                         Console.WriteLine(array2);
                         break;
                     }
                     else
                     {
                         Console.WriteLine("");
                         Console.WriteLine(array2);
                         Console.WriteLine(array);
                         break;
                     }
                    
                 }
                 break;
             }






                 
         }
     }
     
    
    class Program
    {
        
        static void Main(string[] args)
        {
            //Патерн як організувати лабки
           // RotateandSumm l1 = new RotateandSumm();
          //  FoldandSumm l2 = new FoldandSumm();
           // SieveOfEratosthenes l3 = new SieveOfEratosthenes();
          //  sCompareCharArrays l4 = new CompareCharArrays();


        }
    }
}
