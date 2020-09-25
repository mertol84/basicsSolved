using System;

namespace Ex2
{
   class Program
   {
      static void Main(string[] args)
      {
         //Write a program that reads five numbers from the console and prints the greatest of them.

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

         Console.WriteLine("Please enter 3rd number:"); //the same for the third number
         string thirdNo = Console.ReadLine();
         int numberThree;

         if (int.TryParse(thirdNo, out numberThree))
         {

         }

         Console.WriteLine("Please enter 4th number:"); //the same for the 4th number
         string fourthNo = Console.ReadLine();
         int numberFour;

         if (int.TryParse(fourthNo, out numberFour))
         {

         }
         
         Console.WriteLine("Please enter 5th number:"); //the same for the 5th number
         string fifthNo = Console.ReadLine();
         int numberFive;

         if (int.TryParse(fifthNo, out numberFive))
         {

         }

         Console.WriteLine($"The greatest number you've entered is: {Max(numberOne, numberTwo, numberThree, numberFour, numberFive)}"); //with own method
         Console.WriteLine($"The greatest number you've entered is: {Math.Max(numberOne, Math.Max(numberTwo, Math.Max(numberThree, Math.Max(numberFour, numberFive))))}"); //with Math.Max method
      }
      static int Max(int a, int b, int c, int d, int e)
      {
         if (a >= b && a >= c && a >= d && a >= e)
         {
            return a;
         }
         
         if (b >= a && b >= c && b >= d && b >= e)
         {
            return b;
         }

         if (c >= a && c >= b && c >= d && c >= e)
         {
            return c;
         }

         if (d >= a && d >= b && d >= c && d >= e)
         {
            return d;
         }
         
         if (e >= a && e >= b && e >= c && e >= d)
         {
            return e;
         }
         else
         {
            return 0;
         }
      }
   }
}
