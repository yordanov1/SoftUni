using System;

namespace EXER_08._8._FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            double factorialFirstNum= GetFactorial(firstNumber);
            double factorialSecondNum= GetFactorial(secondNumber);

            double result = factorialFirstNum / factorialSecondNum;

            Console.WriteLine($"{result:f2}");
        }

        public static double GetFactorial(int number)
        {
            double result = 1;

            while (number != 1)
            {
                result = result * number;
                number = number - 1;
            }
            return result;
        }
    }
}
