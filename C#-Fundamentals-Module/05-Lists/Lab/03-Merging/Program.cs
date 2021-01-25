using System;
using System.Collections.Generic;
using System.Linq;

namespace LAB_03.Merging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> first = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> second = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> sum = new List<int>();

            int bigger = Math.Max(first.Count, second.Count);

            for (int i = 0; i < bigger ; i++)
            {
                if (first.Count > i)
                {
                    sum.Add(first[i]);
                }
                if (second.Count > i)
                {
                    sum.Add(second[i]);

                }
            }

            Console.WriteLine(string.Join(" ",sum));
        }
    }
}
