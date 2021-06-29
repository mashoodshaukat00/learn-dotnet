using System;

namespace Exercise.CheckLeafYear.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int year2018 = 2018;
            int year2016 = 2016;
            Console.WriteLine($"Year {year2018} is a Leap Year: {IsLeapYear(year2018)}");
            Console.WriteLine($"Year {year2016} is a Leap Year: {IsLeapYear(year2016)}");
        }
        public static bool IsLeapYear(int year)
        {
            return DateTime.IsLeapYear(year);
        }
    }
}
