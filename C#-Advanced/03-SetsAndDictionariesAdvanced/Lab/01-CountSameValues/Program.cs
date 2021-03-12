using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_01._1.CountSameValues
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] inputNumbers = Console.ReadLine()
                                           .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                           .Select(double.Parse)
                                           .ToArray();

            Dictionary<double, int> values = new Dictionary<double, int>();

            for (int i = 0; i < inputNumbers.Length; i++)
            {
                if (!values.ContainsKey(inputNumbers[i]))
                {
                    values.Add(inputNumbers[i], 0);
                }
                values[inputNumbers[i]]++;
            }

            foreach (var item in values)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
