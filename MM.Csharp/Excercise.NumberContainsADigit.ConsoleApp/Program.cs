using System;

namespace Excercise.NumberContainsADigit.ConsoleApp
{
    class Program
    {        
        static void Main(string[] args)
        {
            int number = 7201432;
            int secondNumber = 87501;

            Console.WriteLine($"{number} contains digit 3 : {IfNumberContains3(number)}");
            Console.WriteLine($"{secondNumber} contains digit 3 : {IfNumberContains3(secondNumber)}");
        }

        public static bool IfNumberContains3(int number)
        {
            bool result = false;

            // Implement your logic here.
            return result;
        }

        /*
         *  Write a method that checks if given number (positive integer) contains digit 3.
         *  Do not convert number to other type. Do not use built-in functions like `Contains(), StartsWith()`, etc.

            Expected input and output
            
                IfNumberContains3(7201432) → true
                IfNumberContains3(87501) → false
         */
    }
}
