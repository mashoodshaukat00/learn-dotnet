using System;

namespace Exercise.AddAndMultiply.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
                
        public int AddAndMultiply(int a, int b, int c)
        {
            int d = (a + b) * c;
            return d;
        }

    }
}
