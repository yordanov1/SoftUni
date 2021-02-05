using System;
using System.Collections.Generic;

namespace _3_LAB_Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> wordAndSin = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (wordAndSin.ContainsKey(word))
                {
                    wordAndSin[word].Add(synonym);
                }
                else
                {
                    wordAndSin.Add(word, new List<string>());
                    wordAndSin[word].Add(synonym);
                }
            }

            foreach (var word in wordAndSin)
            {
                Console.WriteLine(word.Key + " - " + string.Join(", ", word.Value));
            }
        }
    }
}
