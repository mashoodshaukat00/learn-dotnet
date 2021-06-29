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
            {
                while (number > 0)
                {
                    if (number % 10 == 3)
                    {
                        return true;
                    }

                    number /= 10;
                }
                return false;                         
            }
        }        
    }
}
