using System;

namespace LAB_01.Convert
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());

            decimal km = meters / 1000M;

            Console.WriteLine($"{km:F2}");
        }
    }
}
