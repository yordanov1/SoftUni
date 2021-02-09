using System;
using System.Collections.Generic;
using System.Linq;

namespace EXER_5_SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> inParking = new Dictionary<string, string>();

            for (int i = 1; i <= n; i++)
            {
                List<string> commands = Console.ReadLine().Split().ToList();

                if (commands.Count < 3)
                {
                    commands.Add("42");
                }
                    string command = commands[0];
                    string person = commands[1];
                    string number = commands[2];

                if (command == "register")
                {
                    if (inParking.ContainsKey(person))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {number}");
                    }
                    else
                    {
                        inParking.Add(person, number);
                        Console.WriteLine($"{person} registered {number} successfully");
                    }
                }
                else if (command == "unregister")
                {
                    if (inParking.ContainsKey(person))
                    {
                        inParking.Remove(person);
                        Console.WriteLine($"{person} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {person} not found");
                    }
                }
            }

            foreach (var person in inParking)
            {
                Console.WriteLine($"{person.Key} => {person.Value}");
            }

        }
    }
}
