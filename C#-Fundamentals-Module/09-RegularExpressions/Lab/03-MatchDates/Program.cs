using System;
using System.Text.RegularExpressions;

namespace LAB_3_MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            string patern = @"\b(?<day>[0-9]{2})([\.\-\/])(?<mounth>[A-Z][a-z]{2})(\1)(?<years>[0-9]{4})\b";
       
            var inputText = Console.ReadLine();

            MatchCollection areTheyMatch = Regex.Matches(inputText, patern);     

            foreach (Match are in areTheyMatch)
            {
                var day = are.Groups["day"].Value;
                string month = are.Groups["mounth"].Value;
                string year = are.Groups["years"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }           
        }
    }
}
