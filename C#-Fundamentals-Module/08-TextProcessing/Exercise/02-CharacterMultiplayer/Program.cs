using System;

namespace EXER_2_CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            string big = string.Empty;
            string small = string.Empty;

            int result = 0;

            if (input[0].Length >= input[1].Length)
            {
                big = input[0];
                small = input[1];
            }
            else
            {
                big = input[1];
                small = input[0];
            }

            for (int i = 0; i < small.Length; i++)
            {
                result += big[i] * small[i];
            }

            if (big != small)
            {
                for (int j = small.Length; j < big.Length; j++)
                {
                    result += big[j];
                }
            }

            Console.WriteLine(result);
        }
    }
}
