using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_03.SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputNumbers = Console.ReadLine()
                                           .Split()
                                           .Reverse()
                                           .ToArray();

            Stack<string> stack = new Stack<string>(inputNumbers);

            while (stack.Count > 1)
            {
                int firstNumber = int.Parse(stack.Pop());
                string symbol = stack.Pop();
                int secondNumber = int.Parse(stack.Pop());


                if (symbol == "+")
                {
                    stack.Push((firstNumber + secondNumber).ToString());
                }
                else if (symbol == "-")
                {
                    stack.Push((firstNumber - secondNumber).ToString());
                }
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
