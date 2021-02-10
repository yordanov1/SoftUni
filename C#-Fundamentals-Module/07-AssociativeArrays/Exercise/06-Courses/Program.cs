using System;
using System.Collections.Generic;
using System.Linq;

namespace EXER_6_Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(" : ").ToList();

            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            while (input[0] != "end")
            {
                string cours = input[0];
                string person = input[1];

                if (!courses.ContainsKey(cours))
                {
                    courses.Add(cours, new List<string>());
                }

                courses[cours].Add(person);

                input = Console.ReadLine().Split(" : ").ToList();
            }

            Dictionary<string, List<string>> sorteds = courses.OrderByDescending(x => x.Value.Count).ToDictionary(z => z.Key, j => j.Value);       

            foreach (var item in courses)
            {
                item.Value.Sort();
            }

            foreach (var cours in sorteds)
            {
                Console.WriteLine($"{cours.Key}: {cours.Value.Count}");

                foreach (var item in cours.Value)
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }
}
