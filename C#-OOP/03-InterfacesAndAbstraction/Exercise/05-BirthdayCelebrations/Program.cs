using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonInfo
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<IBirthable> birtables = new List<IBirthable>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }

                string[] parts = line.Split();

                string type = parts[0];

                if (type == nameof(Citizen))
                {
                    string name = parts[1];
                    int age = int.Parse(parts[2]);
                    string id = parts[3];
                    string birthdate = parts[4];

                    birtables.Add(new Citizen(name, age, id, birthdate));
                }
                else if (type == nameof(Pet))
                {
                    string name = parts[1];
                    string birthdate = parts[2];

                    birtables.Add(new Pet(name, birthdate));
                }
            }

            string filterYear = Console.ReadLine();

            List<IBirthable> filtered = birtables.Where(b => b.Birthdate.EndsWith(filterYear)).ToList();

            foreach (var birtable in filtered)
            {
                Console.WriteLine(birtable.Birthdate);
            }
        }
    }
}
