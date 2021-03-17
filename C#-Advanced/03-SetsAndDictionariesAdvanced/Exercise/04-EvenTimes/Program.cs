using System;
using System.Collections.Generic;

namespace _04.EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int newNumber = int.Parse(Console.ReadLine());

                if (!dictionary.ContainsKey(newNumber))
                {
                    dictionary.Add(newNumber, 0);
                }

                dictionary[newNumber]++;
            }
            

            foreach (var number in dictionary)
            {
                if (number.Value % 2 == 0)
                {
                    Console.WriteLine(number.Key);
                }
            }
            
        }
    }
}
