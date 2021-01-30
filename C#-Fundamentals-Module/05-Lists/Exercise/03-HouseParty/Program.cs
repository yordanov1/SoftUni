using System;
using System.Collections.Generic;
using System.Linq;

namespace EXER_03.HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> persons = new List<string>();
            
            for (int i = 1; i <= n; i++)
            {
                List<string> command = Console.ReadLine().Split().ToList();

                string nameTo = command[0];

                if (command.Count == 3)
                {
                    if (persons.Contains(nameTo))
                    {
                        Console.WriteLine($"{nameTo} is already in the list!");
                    }
                    else
                    {
                        persons.Add(nameTo);
                    }
                }
                else if (command.Count == 4)
                {
                    if (persons.Contains(nameTo))
                    {
                        persons.Remove(nameTo);
                    }
                    else
                    {
                        Console.WriteLine($"{nameTo} is not in the list!");
                    }
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, persons));
        }
    }
}
