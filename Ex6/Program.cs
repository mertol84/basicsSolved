using System;

namespace Ex6
{
   class Program
   {
      static void Main(string[] args)
      {
         //Write a program that reads five integer numbers and prints their sum. 
         //If an invalid number is entered the program should prompt the user to enter another number(only once)

         int a, b, c, d, e;
         bool parseSucceed = false;

         do
         {
            Console.Write("Enter first number");
            parseSucceed = int.TryParse(Console.ReadLine(), out a);
            Console.WriteLine(parseSucceed);
         } while (!parseSucceed);

         do
         {
            Console.Write("Enter second number");
            parseSucceed = int.TryParse(Console.ReadLine(), out b);
            Console.WriteLine(parseSucceed);
         } while (!parseSucceed);

         do
         {
            Console.Write("Enter third number");
            parseSucceed = int.TryParse(Console.ReadLine(), out c);
            Console.WriteLine(parseSucceed);
         } while (!parseSucceed);

         do
         {
            Console.Write("Enter fourth number");
            parseSucceed = int.TryParse(Console.ReadLine(), out d);
            Console.WriteLine(parseSucceed);
         } while (!parseSucceed);

         do
         {
            Console.Write("Enter fifth number");
            parseSucceed = int.TryParse(Console.ReadLine(), out e);
            Console.WriteLine(parseSucceed);
         } while (!parseSucceed);
      }
   }
}
