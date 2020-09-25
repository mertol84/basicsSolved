using System;
using System.Collections.Specialized;

namespace Ex8
{
   class Program
   {
      static void Main(string[] args)
      {
         //Write a program that prints on the console the numbers from 1 to N,
         //which are not divisible by 3 and 7 simultaneously. 
         //The number N should be read from the standard input.

         int numberN;
         bool parseSucceed = false;

         do
         {
            Console.WriteLine("Enter number N: ");
            parseSucceed = int.TryParse(Console.ReadLine(), out numberN);
            Console.WriteLine(parseSucceed);
         } while (!parseSucceed);

         Console.WriteLine($"Numbers divisible with 3 and 7 from you range are a total of: {Divider(numberN)}");

      }

      static int Divider(int a)
      {
         int counter = 0;
         for (int i = 0; i < a; i++)
         {
            if (i % 3 == 0 && i % 7 == 0)
            {
               counter++;
            }
         }
         return counter;
      }
   }
}
