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
            if (word == RevWord) return "true";
            else return "false";

        }
        public int AddAndMultiply(int a, int b, int c)
        {
            int d = (a + b) * c;
            return d;
        }
        public static int IfNumberContains3(int Num)
        {
            int[] NumArray = Num.ToString().ToCharArray().Select(c => int.Parse(c.ToString())).ToArray();
            foreach (int num in NumArray)
            {
                //if (num == 3) return true;
              //  else false;
            }
            return Num;
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
            Console.WriteLine(p.ReverseString("home"));
            Console.WriteLine(p.ReverseString("eye"));
            Console.WriteLine(p.AddAndMultiply(2,4,5));
            Console.WriteLine(IfNumberContains3(7201432));
            Console.WriteLine(CheckYear(2016) ? "true" : "false");
            Console.WriteLine(CheckYear(2018) ? "true" : "false");

        }
        
       


    }
    
}
