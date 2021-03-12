using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_02.AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           
            Dictionary<string, List<decimal>> nameGradeAverage = new Dictionary<string, List<decimal>>();


            for (int i = 0; i < n; i++)
            {
                string[] nameAndGrade = Console.ReadLine()
                                               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                               .ToArray();

                string name = nameAndGrade[0];
                decimal grade = decimal.Parse(nameAndGrade[1]);

                if (!nameGradeAverage.ContainsKey(name))
                {
                    nameGradeAverage.Add(name, new List<decimal>());
                }
                nameGradeAverage[name].Add(grade);
            }

            foreach (var student in nameGradeAverage)
            {
                StringBuilder allGrades = new StringBuilder();

                for (int i = 0; i < student.Value.Count; i++)
                {
                    allGrades.Append($"{student.Value[i]:f2} ");
                }

                Console.WriteLine($"{student.Key} -> {allGrades.ToString()}(avg: {student.Value.Average():f2})");
            }
        }
    }
}
