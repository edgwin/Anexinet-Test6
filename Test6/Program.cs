using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test6
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a function that reverses a string in a memory-efficient manner");
            Console.WriteLine("Write a word or a sentence to reverse:");
            var sentence = Console.ReadLine();
            var response = proccess(sentence);
            Console.WriteLine(response);            
            Console.ReadLine();
        }

        public static string proccess(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return "Invalid input";
            var newString = new StringBuilder();
            for (int i = input.Count() - 1; i >= 0; i--)
            {
                newString.Append(input[i]);
            }
            return newString.ToString();
        }
    }
}
