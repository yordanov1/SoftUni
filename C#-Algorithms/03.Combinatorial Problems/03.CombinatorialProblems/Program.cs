namespace _03.CombinatorialProblems
{
    using System;
    using System.Linq;

    internal class Program
    {

        private static string[] elements;

        static void Main(string[] args)
        {

            var input = Console.ReadLine().Split(" ").Select(x => x).ToArray();

            elements = input;

            Permute(0);
        }

        private static void Permute(int idx)
        {
            if (idx >= elements.Length)
            {
                Console.WriteLine(string.Join(" ", elements));
                return;
            }

            Permute(idx + 1);

            for (int i = idx + 1; i < elements.Length; i++)
            {
                Swap(idx, i);
                Permute(idx + 1);
                Swap(idx, i);
            }
        }

        private static void Swap(int first , int second)
        {
            //(elements[first], elements[second]) = (elements[second], elements[first]);
            var temp = elements[first];
            elements[first] = elements[second];
            elements[second] = temp;
        }
    }
}
