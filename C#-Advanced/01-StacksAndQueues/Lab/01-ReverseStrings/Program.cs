using System;
using System.Collections.Generic;

namespace Lab_01.ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();

            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < inputString.Length; i++)
            {
                stack.Push(inputString[i]);
            }

            while (stack.Count != 0)
            {
                Console.Write(stack.Pop());
            }
        }
    }
}
