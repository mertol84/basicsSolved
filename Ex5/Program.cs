using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Ex5
{
   class Program
   {
      static void Main(string[] args)
      {
         //Write a program that reads two numbers from the console and prints the greater of them. 
         //Solve the problem without using conditional statements and with conditional statements.

         Console.WriteLine("Write a program that reads five numbers from the console and prints the greatest of them."); //def of the problem
         Console.WriteLine("Please enter 1st number:"); //Get 1st no from console
         string firstNo = Console.ReadLine(); //assign 1st no to string
         int numberOne; //define variable for 1st no as integer

         if (int.TryParse(firstNo, out numberOne)) //TryParse string to int
         {

         }

         Console.WriteLine("Please enter 2nd number:"); //the same for the second number
         string secondNo = Console.ReadLine();
         int numberTwo;

         if (int.TryParse(secondNo, out numberTwo))
         {

         }

         Console.WriteLine($"The greatest number you've entered is: {NonCondMax(numberOne, numberTwo)} with nonconditional method"); //with nonconditional method
         Console.WriteLine($"The greatest number you've entered is: {Max(numberOne, numberTwo)} with conditional method"); //with conditional method
         Console.WriteLine($"The greatest number you've entered is: {Math.Max(numberOne, numberTwo)} with math.max method"); //with math.max method
      }
         static int Max(int a, int b)
      {
         if (a >= b)
         {
            return a;
         }
         if (b >= a)
         {
            return b;
         }
         else
         {
            return 0;
         }
      }
      static int NonCondMax(int a, int b)
      {
         return a * ((a / b) > 0 ? 1 : 0) + b * ((b / a) > 0 ? 1 : 0);
      }
   }
}
