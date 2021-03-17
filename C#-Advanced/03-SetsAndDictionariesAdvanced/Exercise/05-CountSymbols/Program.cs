using System;
using System.Collections.Generic;

namespace Exer_05.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            SortedDictionary<char, int> colection = new SortedDictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!colection.ContainsKey(input[i]))
                {
                    colection.Add(input[i], 0);
                }

                colection[input[i]]++;
            }

            foreach (var symbol in colection)
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }
        }
    }
}
