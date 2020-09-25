using System;
using System.Diagnostics.Tracing;

namespace Ex4
{
   class Program
   {
      static void Main(string[] args)
      {
         //Write a program that reads from the console two integer numbers(int) and prints how 
         //many numbers between them exist that are divisible with 5.
         //such that the remainder of their division by 5 is 0.
         //Example: in the range(14, 25) there are 3 such numbers: 15, 20 and 25.

         Console.WriteLine("Insert 1st number:"); //get no from the console and parse str to int
         string firstNo = Console.ReadLine();
         int intFirstNo;

         if (int.TryParse(firstNo, out intFirstNo))
         {

         }
         
         Console.WriteLine("Insert 2nd number:"); //get no from the console and parse str to int
         string secondNo = Console.ReadLine();
         int intSecondNo;

         if (int.TryParse(secondNo, out intSecondNo))
         {

         }

         Console.WriteLine($"Numbers divisible with 5 from you range are a total of: {DivideAndCounter(intFirstNo, intSecondNo)}");
      }

      private static int DivideAndCounter(int a, int b)
      {
         int counter = 0;
         for (int i = a; i <= b; i++)
         {
            if (i % 5 == 0)
            {
               counter++;
            }
         }
            return counter;
      }
   }
}
