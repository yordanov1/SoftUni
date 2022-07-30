namespace _02.PermutationsWithRepetitions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {

        private static string[] elements;
        

        static void Main(string[] args)
        {           
            elements = Console.ReadLine().Split();

            PermutatioWithRepetition(0);
        }

        private static void PermutatioWithRepetition(int idx)
        {
            if (idx >= elements.Length)
            {
                Console.WriteLine(string.Join(" ", elements));
                return;
            }

            PermutatioWithRepetition(idx + 1);

            var used = new HashSet<string> { elements[idx] };

            for (int i = idx + 1; i < elements.Length; i++)
            {
                if (!used.Contains(elements[i]))
                {
                    Swap(idx, i);
                    PermutatioWithRepetition(idx + 1);
                    Swap(idx, i);

                    used.Add(elements[i]);
                }
                
            }
        }

        private static void Swap(int first, int second)
        {
            //(elements[first], elements[second]) = (elements[second], elements[first]);
            var temp = elements[first];
            elements[first] = elements[second];
            elements[second] = temp;
        }
    }
}
