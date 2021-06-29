using System;
using System.Linq;

namespace Exercise.IsPalindrome.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "eye";
            string word2 = "home";
            Console.WriteLine($"{word} is a Palindrome: {IsPalindrome(word)}");
            Console.WriteLine($"{word2} is a Palindrome: {IsPalindrome(word2)}");
        }
        public static bool IsPalindrome(string word) 
        {
            string RevWord = new string(word.Reverse().ToArray());
            if(word == RevWord)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
