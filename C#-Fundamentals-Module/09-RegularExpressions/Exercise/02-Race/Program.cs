using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace EXER_2_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string paternString = @"[A-Za-z]";
            string paternInt = @"[0-9]";

            List<string> players = Console.ReadLine().Split(", ").ToList();

            string cipher = Console.ReadLine();

            Dictionary<string, int> endShifer = new Dictionary<string, int>();

            while (cipher != "end of race")
            {

                Regex regexString = new Regex(paternString);
                Regex regexInt = new Regex(paternInt);

                MatchCollection colectionString = regexString.Matches(cipher);
                MatchCollection colectionInt = regexInt.Matches(cipher);

                string person = String.Concat(colectionString);
                var km = colectionInt.Select(x => int.Parse(x.Value)).Sum();

                if (players.Contains(person))
                {
                    if (!endShifer.ContainsKey(person))
                    {
                        endShifer.Add(person, km);                        
                    }
                    else
                    {
                        endShifer[person] += km;
                    }
                }

                cipher = Console.ReadLine();
            }

             var endShiferOther = endShifer.OrderByDescending(x => x.Value).Select(x =>x.Key).ToList();

            Console.WriteLine($"1st place: {endShiferOther[0]}");
            Console.WriteLine($"2nd place: {endShiferOther[1]}");
            Console.WriteLine($"3rd place: {endShiferOther[2]}");
        }
    }
}
