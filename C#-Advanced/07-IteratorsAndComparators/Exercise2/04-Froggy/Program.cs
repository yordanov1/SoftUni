using Exer_04.Froggy;
using System;
using System.Linq;

namespace IteratorsAndComparators
{
    public class StartUp
    {
        public static void Main()
        {
            var inputNumbers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var lake = new Lake(inputNumbers);
            Cat cat = new Cat();

            Console.WriteLine(lake.stones[0]);
            Console.WriteLine(lake.stones[1]);
            Console.WriteLine(lake.stones[2]);
            Console.WriteLine(lake.stones[3]);

            Console.WriteLine(string.Join(", ", lake));
        }
    }
}