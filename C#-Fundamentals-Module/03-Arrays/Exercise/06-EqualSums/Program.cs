using System;
using System.Linq;

namespace EXER_06.EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine()
                          .Split().Select(int.Parse)
                          .ToArray();

            bool no = true;

            for (int i = 0; i < number.Length; i++)
            {
                int currentNumber = number[i];

                int right = 0;
                int left = 0;

                for (int j = i + 1; j < number.Length; j++)
                {
                    right = right + number[j];
                }
                
                for (int z = i - 1; z >= 0; z--)
                {
                    left = left + number[z];
                }

                if(left == right)
                {
                    Console.WriteLine(i);
                    no = false;
                    break;
                }
            }
            
            if (no)
            {
                Console.WriteLine("no");
            }            
        }
    }
}
