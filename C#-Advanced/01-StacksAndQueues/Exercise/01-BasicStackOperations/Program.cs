using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Exer_01.BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] NSX = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> numbers = new Stack<int>(inputNumbers);

            if (numbers.Count - NSX[1] >= 0)
            {
                for (int i = 0; i < NSX[1]; i++)
                {
                    numbers.Pop();
                }
            }
            else
            {
                numbers.Clear();
            }

            if (numbers.Count != 0)
            {
                if (numbers.Contains(NSX[2]))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(numbers.Min());
                }
            }
            else
            {
                Console.WriteLine("0");
            }            
        }
    }
}
