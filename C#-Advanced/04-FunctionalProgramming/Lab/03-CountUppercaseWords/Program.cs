using System;
using System.Linq;

namespace Lab_03.CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> func = n => n[0] == n.ToUpper()[0];

            string[] inputText = Console.ReadLine()
                                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                        .Where(func)
                                        .ToArray();

            foreach (var word in inputText)
            {
                Console.WriteLine(word);
            }
        }
    }
}
