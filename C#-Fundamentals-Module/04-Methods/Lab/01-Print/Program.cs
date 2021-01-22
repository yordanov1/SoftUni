using System;

namespace LAB_01.Print
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Print(number);           
        }

        static void Print(int num)
        {
            if (num > 0)
            {
                Console.WriteLine($"The number {num} is positive.");
            }
            else if (num < 0)
            {
                Console.WriteLine($"The number {num} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {num} is zero.");
            }
        }
    }
}
