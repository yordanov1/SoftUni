using System;
using System.Collections.Generic;
using System.Linq;

namespace Exer_03.PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SortedSet<string> uniqueElements = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] newElements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int j = 0; j < newElements.Length; j++)
                {
                    uniqueElements.Add(newElements[j]);
                }
            }

            Console.WriteLine(string.Join(" ", uniqueElements));
        }
    }
}
