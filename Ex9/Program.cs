using System;

namespace Ex9
{
   class Program
   {
      static void Main(string[] args)
      {
         //Write a program that reads from the console a series of 5 integers and prints the smallest and largest of them.

         int lowest = 0, highest = 0, input;

         Console.Write("Enter numbers length: ");
         int lenght = Int32.Parse(Console.ReadLine());

         for (int i = 0; i < lenght; i++)
         {
            Console.Write("Enter number: ");
            input = Int32.Parse(Console.ReadLine());
            if (i == 0) lowest = highest = input;
            else
            {
               if (lowest > input) lowest = input;
               if (highest < input) highest = input;
            }
         }
         Console.WriteLine("Lowest - {0}, Highest - {1}", lowest, highest);


         //   int iterationNo, noToComp;
         //   bool parseSucceed = false;

         //   do
         //   {
         //      Console.WriteLine("Enter no of numbers you want to compare: ");
         //      parseSucceed = int.TryParse(Console.ReadLine(), out iterationNo);
         //      Console.WriteLine(parseSucceed);
         //   } while (!parseSucceed);

         //   do
         //   {
         //      Console.WriteLine("Enter number: ");
         //      parseSucceed = int.TryParse(Console.ReadLine(), out noToComp);
         //      Console.WriteLine(parseSucceed);
         //   } while (!parseSucceed);

         //   Console.WriteLine(MinMax(iterationNo, noToComp));
         //}

         //static int MinMax(int a, int b)
         //{
         //   int min = 0, max = 0;
         //   for (int i = 0; i < a; i++)
         //   {
         //      if (i == 0)
         //      {
         //         min = max = b;
         //      }
         //      else
         //      {
         //         if (min > b)
         //         {
         //            min = b;
         //         }
         //         if (max < b)
         //         {
         //            max = b;
         //         }
         //      }
         //      Console.WriteLine($"Smallest number you have entered is {min} and largest is {max}");
         //   }
         //   return min;
         //}
      }
   }
}
