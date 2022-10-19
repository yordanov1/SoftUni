namespace _06.SchoolTeams
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {


            var girls = Console.ReadLine().Split(", ");
            var girlsComb = new string[3];
            var girlsCombs = new List<string[]>();


            GenCombs(0, 0, girls, girlsComb, girlsCombs);

            var boys = Console.ReadLine().Split(", ");
            var boysComb = new string[2];
            var boysCombs = new List<string[]>();

            GenCombs(0, 0, boys, boysComb, boysCombs);

            PrintFinalCombs(girlsCombs, boysCombs);
        }

        private static void PrintFinalCombs(List<string[]> girlsCombs, List<string[]> boysCombs)
        {
            foreach (var girlsComb in girlsCombs)
            {
                foreach (var boysComb in boysCombs)
                {
                    Console.WriteLine($"{String.Join(", ", girlsComb)}, {String.Join(", ", boysComb)}");
                }
            }
        }

        private static void GenCombs(int idx, int start, string[] elements, string[] comb, List<string[]> combs)
        {
            if (idx >= comb.Length)
            {
                combs.Add(comb.ToArray());
                return;
            }

            for (int i = start; i < elements.Length; i++)
            {
                comb[idx] = elements[i];
                GenCombs(idx + 1, i + 1, elements, comb, combs);
            }
        }
    }
}
