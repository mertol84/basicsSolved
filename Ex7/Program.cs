using System;

namespace Ex7
{
   class Program
   {
      static void Main(string[] args)
      {
         //Write a program that prints on the console the numbers from 1 to N. 
         //The number N should be read from the standard input.

         int numberN;
         bool parseSucceed = false;

         do
         {
            Console.Write("Enter number ");
            parseSucceed = int.TryParse(Console.ReadLine(), out numberN);
            Console.WriteLine(parseSucceed);
         } while (!parseSucceed);

         Console.WriteLine(Counter(numberN));
      }

      static int Counter(int a)
      {
         int counter = 0;
         for (int i = 1; i < a; i++)
         {
            Console.WriteLine(i);
         }
         return a;
      }
   }
}
