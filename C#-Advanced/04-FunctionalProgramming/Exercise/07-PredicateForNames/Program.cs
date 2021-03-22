using System;
using System.Collections.Generic;
using System.Linq;

namespace Exer_07.PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int nameLength = int.Parse(Console.ReadLine());

            Func<string, bool> filterFunc = x => x.Length <= nameLength;

            List<string> names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(filterFunc)
                .ToList();

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
