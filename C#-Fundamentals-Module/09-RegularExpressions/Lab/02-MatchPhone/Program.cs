using System;
using System.Text.RegularExpressions;

namespace LAB_2_MatchPhone
{
    class Program
    {
        static void Main(string[] args)
        {
            string patern = @"\+359(-? ?)2(.)[0-9]{3}(\1)[0-9]{4}\b";
            
            Regex regex = new Regex(patern);
            string input = Console.ReadLine();

            MatchCollection willMach = regex.Matches(input);
            
            Console.WriteLine(string.Join(", ", willMach));
        }
    }
}
