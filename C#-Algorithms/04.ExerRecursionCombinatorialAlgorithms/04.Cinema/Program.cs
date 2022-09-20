namespace _04.Cinema
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    internal class Program
    {
        private static List<string> nonSaticPeole;
        private static string[] people;
        private static bool[] locked;

        static void Main(string[] args)
        {
            nonSaticPeole = Console.ReadLine().Split(", ").ToList();
            people = new string[nonSaticPeole.Count];
            locked = new bool[nonSaticPeole.Count];

            while (true)
            {
                var line = Console.ReadLine();

                if (line == "generate")
                {
                    break;
                }

                var parts = line.Split(" - ");
                var name = parts[0];
                var position = int.Parse(parts[1]) - 1;

                people[position] = name;
                locked[position] = true;

                nonSaticPeole.Remove(name);
            }

            Permute(0);
        }

        private static void Permute(int idx)
        {
            if (idx >= nonSaticPeole.Count)
            {
                PrintPermutation();
                return;
            }

            Permute(idx + 1);

            for (int i = idx + 1; i < nonSaticPeole.Count; i++)
            {
                Swap(idx, i);
                Permute(idx + 1);
                Swap(idx, i);

            }
        }

        private static void PrintPermutation()
        {
            var peopleIdx = 0;
            var sb = new StringBuilder();

            for (int i = 0; i < people.Length; i++)
            {
                if (locked[i])
                {
                    sb.Append($"{people[i]} ");
                }
                else
                {
                    sb.Append($"{nonSaticPeole[peopleIdx++]} ");                    
                }
            }

            Console.WriteLine(sb.ToString().Trim());
        }

        private static void Swap(int first, int second)
        {
            var temp = nonSaticPeole[first];
            nonSaticPeole[first] = nonSaticPeole[second];
            nonSaticPeole[second] = temp;
        }
    }
}
