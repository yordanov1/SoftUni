using System;
using System.Collections.Generic;

namespace EXER_1_CountChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Dictionary<char, int> counter = new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ')
                {
                    if (!counter.ContainsKey(text[i]))
                    {
                        counter.Add(text[i], 1);
                    }
                    else
                    {
                        counter[text[i]]++;
                    }
                }
            }

            foreach (var symbol in counter)
            {
                Console.WriteLine(symbol.Key + " -> " + symbol.Value);
            }
        }
    }
}
