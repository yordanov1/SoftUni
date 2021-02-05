using System;
using System.Collections.Generic;
using System.Linq;

namespace _4_LAB_Largest_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                       .Split()
                                       .Select(int.Parse)
                                       .OrderByDescending(i => i)
                                       .Take(3)
                                       .ToList();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
