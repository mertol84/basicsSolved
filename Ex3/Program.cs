using System;

namespace Ex3
{
   class Program
   {
      static void Main(string[] args)
      {
         //Write a program that reads from the console the radius "r" of a circle and prints its perimeter and area.

         Console.WriteLine("Enter the radius of the circle:");
         string strRadius = Console.ReadLine();
         double dRadius;

         if (double.TryParse(strRadius, out dRadius))
         {

         }

         Console.WriteLine($"Perimeter of the Circle is: {Perimeter(dRadius)}");
         Console.WriteLine($"Area of the Circle is: {Area(dRadius)}");
      }

      static double Perimeter(double a)
      {
         return 2 * Math.PI * a;
      }

      static double Area(double a)
      {
         return a * a * Math.PI;
      }
   }
}
