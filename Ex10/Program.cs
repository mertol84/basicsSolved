using System;
using System.Linq;

namespace Ex10
{
   class Program
   {
      static void Main(string[] args)
      {
         //Write program that outputs a triangle made of stars with variable size, depending on an input parameter.
         //Look at the examples to get an idea. The input comes as a string number, which needs to be parsed to a number.
         //The output is a series of lines printed on the console, forming a triangle of variable size.

         Trinagle();
      }

      static void Trinagle()
      {
         int a, b, input;
         bool parseSucceed = false;

         do
         {
            Console.WriteLine("Enter number of stars to draw: ");
            parseSucceed = int.TryParse(Console.ReadLine(), out input);
            Console.WriteLine(parseSucceed);
         } while (!parseSucceed);


         for (a = 1; a <= input; a++)
         {
            for (b = 1; b <= a; b++)
            {
               Console.Write("*");
            }
            Console.WriteLine("");
         }
         for (a = input - 1; a >= 0; a--)
         {
            for (b = 1; b <= a; b++)
            {
               Console.Write("*");
            }
            Console.WriteLine("");
         }
      }
   }
}
