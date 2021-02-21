using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_05.PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> evenNumbers = new Queue<int>();           

            for (int i = 0; i < numbers.Length; i++)
            {

                int currentNumber = numbers[i];

                if (currentNumber % 2 == 0)
                {
                    evenNumbers.Enqueue(currentNumber);
                }    
            }
            
            Console.WriteLine(string.Join(", ",evenNumbers));           
        }
    }
}
