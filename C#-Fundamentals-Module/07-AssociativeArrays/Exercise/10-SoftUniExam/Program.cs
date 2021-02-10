using System;
using System.Collections.Generic;
using System.Linq;

namespace EXER_10_SoftUniExam
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split("-").ToList();

            Dictionary<string, int> results = new Dictionary<string, int>();
            Dictionary<string, int> points = new Dictionary<string, int>();

            while (input[0] != "exam finished")
            {                
                if (input.Count > 2)
                {
                    string person = input[0];
                    string tehnology = input[1];
                    int pointPerExam = int.Parse(input[2]);

                    if (!results.ContainsKey(person))
                    {
                        results.Add(person, 0);
                    }

                    if (results[person] < pointPerExam)
                    {
                        results[person] = pointPerExam;
                    }
                    
                    if (!points.ContainsKey(tehnology))
                    {
                        points.Add(tehnology, 0);
                    }

                    points[tehnology]++;
                }
                else
                {
                    string person = input[0];
                    string banned = input[1];
                    if (results.ContainsKey(person))
                    {
                        results.Remove(person);
                    }
                }

                input = Console.ReadLine().Split("-").ToList();
            }

            Console.WriteLine("Results:");

            foreach (var result in results.OrderByDescending(x => x.Value).ThenBy(y => y.Key))
            {
                Console.WriteLine($"{result.Key} | {result.Value}");
            }

            Console.WriteLine("Submissions:");

            foreach (var point in points.OrderByDescending(x => x.Value).ThenBy(y => y.Key))
            {
                Console.WriteLine($"{point.Key} - {point.Value}");
            }
        }
    }
}
