using System;
using System.Collections.Generic;
using System.Linq;

namespace EXER_05.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> element = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] bombDefinition = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int bomb = bombDefinition[0];
            int range = bombDefinition[1];

            int bombIndex = element.IndexOf(bomb);

            while (bombIndex != -1)
            {
                int leftRange = bombIndex - range;
                int rightRange = bombIndex + range;

                if (leftRange < 0)
                {
                    leftRange = 0;
                }
                if (rightRange > (element.Count - 1))
                {
                    rightRange = element.Count - 1;
                }

                element.RemoveRange(leftRange, rightRange - leftRange + 1);
                bombIndex = element.IndexOf(bomb);
            }

            int sum = element.Sum();
            
            Console.WriteLine(sum);
        }
    }
}
