using System;

namespace MORE_01.SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            double third = double.Parse(Console.ReadLine());


            if(first > second && first > third)
            {
                Console.WriteLine(first);
             if(second > third)
                {
                    Console.WriteLine(second);
                    Console.WriteLine(third);
                }
                else
                {
                    Console.WriteLine(third);
                    Console.WriteLine(second);
                }
            }
            else if(second > first && second > third)
            {
                Console.WriteLine(second);
                if(first > third)
                {
                    Console.WriteLine(first);
                    Console.WriteLine(third);
                }
                else
                {
                    Console.WriteLine(third);
                    Console.WriteLine(first);
                }
            }
            else if(third > first && third > second)
            {
                Console.WriteLine(third);
                if(first > second)
                {
                    Console.WriteLine(first);
                    Console.WriteLine(second);
                }
                else
                {
                    Console.WriteLine(second);
                    Console.WriteLine(first);
                }
            }
        }
    }
}
