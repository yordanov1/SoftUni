using System;
using System.Reflection.PortableExecutable;

namespace EXER_06.MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string output = string.Empty;

            if (input.Length % 2 == 0)
            {
                 output = GetMiddleCharFromEvenStringLenght(input);                
            }
            else
            {
                output = GetMiddleCharFronmStringLenght(input);
            }

            Console.WriteLine(output);
        }

        private static string GetMiddleCharFronmStringLenght(string input)
        {
            int index = input.Length / 2;
            string chars = input.Substring(index, 1);
            return chars;
        }

        private static string GetMiddleCharFromEvenStringLenght(string input)
        {
            int index = input.Length / 2;
            string chars = input.Substring(index -1, 2);
            return chars;
        }
    }
}
