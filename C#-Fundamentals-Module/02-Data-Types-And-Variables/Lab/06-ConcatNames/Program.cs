using System;

namespace LAB_06.ConcatNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOne = Console.ReadLine();
            string nameTwo = Console.ReadLine();
            string symbol = Console.ReadLine();

            Console.WriteLine($"{nameOne}{symbol}{nameTwo}");
        }
    }
}
