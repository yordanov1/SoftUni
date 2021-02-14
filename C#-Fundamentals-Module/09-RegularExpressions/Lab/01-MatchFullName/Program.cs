using System;
using System.Text.RegularExpressions;

namespace LAB_1_MatchFullName
{
    class Program
    {
        public static object MathColection { get; private set; }

        static void Main(string[] args)
        {
            string patern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            Regex regex = new Regex(patern);

            string input = Console.ReadLine();

            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                Console.Write($"{match} ");
            }
        }
    }
}
