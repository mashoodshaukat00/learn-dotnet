using System;
using System.Linq;

namespace loops_practice
{
    class Program
    {
        public string ReverseString(string srtVariable)
        {
            string word = srtVariable;
            string RevWord = new string(srtVariable.Reverse().ToArray());
            if (word == RevWord)
            {
                return "true";
            }
            else
            {
                return "false";
            }
        }
        public int AddAndMultiply(int a, int b, int c)
        {
            int d = (a + b) * c;
            return d;
        }

        public static bool IfNumberContain3(int input)
        {
            while (input > 0)
            {
                if (input % 10 == 3)
                {
                    return true;
                }

                input /= 10;
            }

            return false;
        }
        public static bool IfNumberContains3(int Num)
        {
            char[] NumArray = Num.ToString().ToCharArray();

            bool result = false;

            foreach (char num in NumArray)
            {
                if (num == '3')
                {
                    result = true;
                    break;
                }
                else
                {
                    result = false;
                }
            }
            return result;

        }
        static bool CheckYear(int year)
        {
            // Return true if year is a multiple
            // of 4 and not multiple of 100.
            // OR year is multiple of 400.
            return (((year % 4 == 0) && (year % 100 != 0)) ||
                    (year % 400 == 0));
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            //Console.WriteLine(p.ReverseString("home"));
            //Console.WriteLine(p.ReverseString("eye"));
            //Console.WriteLine(p.AddAndMultiply(2,4,5));
            //Console.WriteLine(IfNumberContains3(7201432));
            //Console.WriteLine(CheckYear(2016) ? "true" : "false");
            //Console.WriteLine(CheckYear(2018) ? "true" : "false");

            int number = 12456;

            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine($"Number : {number} contains 3 : {IfNumberContain3(number)}");
                number++;
            }

        }




    }

}
