using System;
using System.Collections.Generic;
using System.Linq;

namespace ASOCIATIVE_ARRAYS
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            SortedDictionary<int, int> dublation = new SortedDictionary<int, int>();

            foreach (int number in numbers)
            {
                if (dublation.ContainsKey(number))
                {
                    dublation[number]++; 
                }
                else
                {
                    dublation.Add(number, 1);
                }
            }

            foreach (var number in dublation)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
