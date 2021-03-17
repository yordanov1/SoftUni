using System;
using System.Collections.Generic;
using System.Linq;

namespace Exer_06.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> collection = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string colour = input[0];
                string[] garment = input[1].Split(",",StringSplitOptions.RemoveEmptyEntries).ToArray();


                if (!collection.ContainsKey(colour))
                {
                    collection.Add(colour, new Dictionary<string, int>());
                }

                for (int j = 0; j < garment.Length; j++)
                {
                    if (!collection[colour].ContainsKey(garment[j]))
                    {
                        collection[colour].Add(garment[j], 0);
                    }

                    collection[colour][garment[j]]++;
                }
            }

            string[] searchGarment = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach (var colour in collection)
            {
                Console.WriteLine($"{colour.Key} clothes:");

                foreach (var garment in colour.Value)
                {
                    if (searchGarment[0] == colour.Key && searchGarment[1] == garment.Key)
                    {
                        Console.WriteLine($"* {garment.Key} - {garment.Value} (found!)"); 
                    }
                    else
                    {
                        Console.WriteLine($"* {garment.Key} - {garment.Value}");
                    }
                }
            }
        }
    }
}
