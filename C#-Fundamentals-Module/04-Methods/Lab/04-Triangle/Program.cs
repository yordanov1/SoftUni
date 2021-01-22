using System;

namespace LAB_04.Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 1;
            int end = int.Parse(Console.ReadLine());

            PrintLine(start, );
        }

        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
