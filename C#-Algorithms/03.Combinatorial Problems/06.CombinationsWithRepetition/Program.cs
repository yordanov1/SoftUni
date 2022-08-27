namespace _06.CombinationsWithRepetition
{
    using System;

    internal class Program
    {
        private static int k;
        private static string[] elements;
        private static string[] combinations;

        static void Main(string[] args)
        {
            elements = Console.ReadLine().Split();
            k = int.Parse(Console.ReadLine());

            combinations = new string[k];

            GenCombinations(0, 0);
        }

        private static void GenCombinations(int idx, int elementsStartIdx)
        {
            if (idx >= combinations.Length)
            {
                Console.WriteLine(String.Join(" ", combinations));
                return;
            }

            for (int i = elementsStartIdx; i < elements.Length; i++)
            {
                combinations[idx] = elements[i];
                GenCombinations(idx + 1, i);
            }
        }
    }
}
