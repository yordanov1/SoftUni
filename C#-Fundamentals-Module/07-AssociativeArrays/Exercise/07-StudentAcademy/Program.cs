using System;
using System.Collections.Generic;
using System.Linq;

namespace EXER_7_StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> studentsDic = new Dictionary<string, List<double>>();
            Dictionary<string, double> average = new Dictionary<string, double>();

            for (int i = 1; i <= n; i++)
            {
                string student = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentsDic.ContainsKey(student))
                {
                    studentsDic.Add(student, new List<double>());
                }
                studentsDic[student].Add(grade);
            }

            foreach (var item in studentsDic)
            {
                double hoho = item.Value.Average();
                if (hoho >= 4.5)
                {
                    average.Add(item.Key, hoho);
                }               
            }

            foreach (var item in average.OrderByDescending(x => x.Value))
            {                
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }

        }
    }
}
