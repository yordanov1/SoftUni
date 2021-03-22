using System;
using System.Collections.Generic;
using System.Linq;

namespace Exer_06.ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Reverse()
                .ToList();

            int divisor = int.Parse(Console.ReadLine());

            Console.WriteLine(string.Join(" ", numbers.Where(x => x % divisor != 0)));
        }
    }
}
