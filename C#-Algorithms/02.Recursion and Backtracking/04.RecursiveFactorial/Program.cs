namespace _04.RecursiveFactorial
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            Console.WriteLine(SumFactorial(number));
        }

        public static int SumFactorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }

            if (number == 1)
            {
                return 1;
            }

            return number * SumFactorial(number - 1);
        }
    }
}
