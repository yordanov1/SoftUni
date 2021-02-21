using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab_04.MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputNumbers = Console.ReadLine();

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < inputNumbers.Length; i++)
            {
                if (inputNumbers[i] == '(')
                {
                    stack.Push(i);
                }
                if (inputNumbers[i] == ')')
                {
                    int start = stack.Pop();
                    Console.WriteLine(inputNumbers.Substring(start, i - start + 1));
                }
            }

        }
    }
}
