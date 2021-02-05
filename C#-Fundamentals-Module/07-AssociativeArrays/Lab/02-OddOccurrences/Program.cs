using System;
using System.Collections.Generic;
using System.Linq;

namespace LAB_2_OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().ToList();

            Dictionary<string, int> times = new Dictionary<string, int>();

            foreach (var time in words)
            {
                string wordInLowerCase = time.ToLower();

                if (times.ContainsKey(wordInLowerCase))
                {
                    times[wordInLowerCase]++;
                }
                else
                {
                    times.Add(wordInLowerCase, 1);
                }
            }

            foreach (var time in times)
            {
                if (time.Value % 2 == 1)
                {
                    Console.Write(time.Key + " ");
                }
            }
        }
    }
}
