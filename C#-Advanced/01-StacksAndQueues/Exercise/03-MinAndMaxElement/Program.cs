using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Exer_03.MinAndMaxElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            Stack<int> stackNumbers = new Stack<int>();

            for (int i = 0; i < N; i++)
            {
                int[] command = Console.ReadLine().Split().Select(int.Parse).ToArray();
                
                if (command[0] == 1)
                {
                    int number = command[1];
                    stackNumbers.Push(number);
                }
                else if (command[0] == 2) 
                {
                    if (stackNumbers.Count > 0)
                    {
                    stackNumbers.Pop();
                    }
                }
                else if (command[0] == 3) 
                {
                    if (stackNumbers.Count > 0)
                    {
                        Console.WriteLine(stackNumbers.Max());
                    }                    
                }
                else if (command[0] == 4) 
                {
                    if (stackNumbers.Count > 0)
                    {
                    Console.WriteLine(stackNumbers.Min());
                    }
                }
            }

            Console.WriteLine(string.Join(", ", stackNumbers));
        }
    }
}
