using System;

namespace Exercise.AddAndMultiply.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"By adding first two numbers and multiplying by third, Result: {AddAndMultiply(2,3,6)}");
        }
                
        public static int AddAndMultiply(int AddNum1, int AddNum2, int MultiplyNum3)
        {
            return (AddNum1 + AddNum2) * MultiplyNum3;            
        }

    }
}
