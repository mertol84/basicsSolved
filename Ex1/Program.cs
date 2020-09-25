using System;

namespace Ex1
{
   class Program
   {
      static void Main(string[] args)
      {
         //Write a program that reads from the console three numbers of type int and prints their sum.

         Console.WriteLine("Write a program that reads from the console three numbers of type int and prints their sum."); //def of the problem
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
         
         Console.WriteLine("Please enter 3rd number:"); //the same for the third number
         string thirdNo = Console.ReadLine();
         int numberThree;

         if (int.TryParse(thirdNo, out numberThree))
         {

         }

         Console.WriteLine($"The sum of the three numbers you've entered is: {Sum(numberOne, numberTwo, numberThree)}");

      }
      static int Sum(int a, int b, int c)
      {
         return a + b + c;
      }
   }
}
