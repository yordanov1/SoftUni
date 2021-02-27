using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Exer_05.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputClothes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int capacity = int.Parse(Console.ReadLine());
            int clothesLeft = capacity;

            int counter = 0;         

            Stack<int> clothes = new Stack<int>(inputClothes);

            while (clothes.Count != 0)
            {
                if (clothesLeft - clothes.Peek() < 0)
                {
                    clothesLeft = capacity;
                    counter++;
                }
                else
                {                   
                    clothesLeft -= clothes.Pop();
                }
            }

            counter++;

            Console.WriteLine(counter);
        }
    }
}
