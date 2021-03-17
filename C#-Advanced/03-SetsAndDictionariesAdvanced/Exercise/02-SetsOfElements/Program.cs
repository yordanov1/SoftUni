using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                 .Select(int.Parse)
                                 .ToArray();

            int firs = input[0];
            int secod = input[1];

            HashSet<int> firstSet = new HashSet<int>(); 
            HashSet<int> secondSet = new HashSet<int>();

            for (int i = 0; i < firs; i++)
            {
                int newNumber = int.Parse(Console.ReadLine());
                firstSet.Add(newNumber);
            }

            for (int i = 0; i < secod; i++)
            {
                int newNumber = int.Parse(Console.ReadLine());
                secondSet.Add(newNumber);
            }

            var intersection = firstSet.Intersect(secondSet);

            Console.WriteLine(string.Join(" ",intersection));
        }
    }
}
