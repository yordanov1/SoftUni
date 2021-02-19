using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;


namespace EXER_04_StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int messegesCount = int.Parse(Console.ReadLine());

            List<string> listA = new List<string>();
            List<string> listD = new List<string>();
            
            for (int i = 0; i < messegesCount; i++)
            {
                string text = Console.ReadLine();

                int count = 0;

                for (int j = 0; j < text.Length; j++)
                {
                    if (text[j] == 's' || text[j] == 't' || text[j] == 'a' || text[j] == 'r'
                     || text[j] == 'S' || text[j] == 'T' || text[j] == 'A' || text[j] == 'R')
                    {
                        count++;
                    }
                }  
                
                string decryptedText = string.Empty;

                for (int j = 0; j < text.Length; j++)
                {
                    decryptedText = decryptedText + (char)(text[j] - count);
                }
               

                string paternA = @"@(?<planets>[A-Za-z]+)[^@!:>-]*:(?<population>[0-9]+)[^@!:>-]*!(?<attack>[A])![^@!:>-]*->(?<soldier>[0-9]+)";
                string paternD = @"@(?<planets>[A-Za-z]+)[^@!:>-]*:(?<population>[0-9]+)[^@!:>-]*!(?<attack>[D])![^@!:>-]*->(?<soldier>[0-9]+)";


                Regex regexA = new Regex(paternA);
                Regex regexD = new Regex(paternD);
                
                Match colectionA = regexA.Match(decryptedText);
                Match colectionD = regexD.Match(decryptedText);

                if (colectionA.Success)
                {
                    listA.Add(colectionA.Groups["planets"].Value);
                }
                else if (colectionD.Success)
                {
                    listD.Add(colectionD.Groups["planets"].Value);
                }            
            }

            listA = listA.OrderBy(x => x).ToList();
            listD = listD.OrderBy(x => x).ToList();

            Console.WriteLine($"Attacked planets: {listA.Count}");

            for (int i = 0; i < listA.Count; i++)
            {
                Console.WriteLine($"-> {listA[i]}");
            }

            Console.WriteLine($"Destroyed planets: {listD.Count}");

            for (int i = 0; i < listD.Count; i++)
            {
                Console.WriteLine($"-> {listD[i]}");
            }
        }
    }
}
