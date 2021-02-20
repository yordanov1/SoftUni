using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_02.StackSum
{
    class Program
    {
        static void Main(string[] args)
        {            
            int[] inputNumbers = Console.ReadLine()
                                        .Split()
                                        .Select(int.Parse)
                                        .ToArray();

            Stack<int> stack = new Stack<int>(inputNumbers);

            string command = Console.ReadLine().ToLower();

            while (command != "end")
            {
                string[] commands = command.Split().ToArray();

                if (commands[0] == "add")
                {
                    int firstNumber = int.Parse(commands[1]);
                    int secondNumber = int.Parse(commands[2]);

                    stack.Push(firstNumber);
                    stack.Push(secondNumber);

                }
                else if (commands[0] == "remove")
                {
                    int positionToRemove = int.Parse(commands[1]);

                    if (stack.Count - positionToRemove >= 0)
                    {
                        for (int i = 0; i < positionToRemove; i++)
                        {
                            stack.Pop();
                        }
                    }                 
                }

                command = Console.ReadLine().ToLower();
            }

            int sum = 0;           

            foreach (var item in stack)
            {
                sum += item;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
