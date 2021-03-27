using System;
using System.Collections.Generic;
using System.Linq;

namespace Exer_04.GenericSwapMethod
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> names = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int name = int.Parse(Console.ReadLine());
                names.Add(name);
            }

            Box<int> box = new Box<int>(names);

            int[] indexesToSwap = Console.ReadLine()
                .Split().Select(int.Parse)
                .ToArray();

            box.Swap(names, indexesToSwap[0], indexesToSwap[1]);

            Console.WriteLine(box);
        }
    }
}
