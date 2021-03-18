using System;
using System.Linq;

namespace Lab_04.AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] input = Console.ReadLine()
                                     .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                     .Select(decimal.Parse)
                                     .Select(x => x * 1.2m)
                                     .ToArray();

            foreach (var number in input)
            {
                Console.WriteLine($"{number:f2}");
            }
        }
    }
}
