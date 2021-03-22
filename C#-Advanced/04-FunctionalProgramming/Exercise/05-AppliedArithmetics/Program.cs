using System;
using System.Linq;

namespace Exer_05.AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                 .Select(int.Parse)
                                 .ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                if (command == "add")
                {
                    numbers = numbers
                        .Select(x => x + 1)
                        .ToList();
                }
                else if (command == "multiply")
                {
                    numbers = numbers
                        .Select(x => x * 2)
                        .ToList();
                }
                else if (command == "subtract")
                {
                    numbers = numbers
                        .Select(x => x - 1)
                        .ToList();
                }
                else if (command == "print")
                {
                    Console.WriteLine(string.Join(" ", numbers));
                }

                command = Console.ReadLine();
            }
        }
    }
}
