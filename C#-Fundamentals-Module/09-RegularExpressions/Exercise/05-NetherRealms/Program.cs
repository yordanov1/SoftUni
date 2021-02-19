using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace EXER_5_NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            string demonNames = Console.ReadLine();

            char[] separators = new char[] { ',', ' ' };

            List<string> names = demonNames.Split(separators, StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x).ToList();

            for (int i = 0; i < names.Count; i++)
            {
                string demonName = names[i];

                string paternHelt = @"[^\*\/\+\-\/\.0-9]";               
                string paternDamage = @"(\-*[0-9]+\.*[0-9]*)";
                

                Regex regexHelt = new Regex(paternHelt);
                Regex regexDamage = new Regex(paternDamage);

                MatchCollection matchesHelt = regexHelt.Matches(demonName);
                MatchCollection matchesDamage = regexDamage.Matches(demonName);


                int counter = 0;
                double counterDMG = 0.00;


                foreach (Match match in matchesHelt)
                {
                    counter += char.Parse(match.Value);
                }

                foreach (Match match in matchesDamage)
                {
                        counterDMG += double.Parse(match.Value);                
                }

                foreach (var item in demonName)
                {
                    if (item == '*')
                    {
                        counterDMG = counterDMG * 2;
                    }
                    if (item == '/')
                    {
                        counterDMG = counterDMG / 2;
                    }
                }

                Console.WriteLine($"{demonName} - {counter} health, {counterDMG:f2} damage");
            }
        }
    }
}
