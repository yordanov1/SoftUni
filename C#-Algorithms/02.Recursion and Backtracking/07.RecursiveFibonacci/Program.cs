namespace _07.RecursiveFibonacci
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            Console.WriteLine(CalcFib(input)); // 89
            //Console.WriteLine(CalcFib(50));
        }

        static long CalcFib(int number)
        {
            if (number <= 1)
            {
                return 1;
            }
            return CalcFib(number - 1) + CalcFib(number - 2);
        }

    }
}
