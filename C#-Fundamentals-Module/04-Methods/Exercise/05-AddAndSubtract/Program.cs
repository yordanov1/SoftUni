using System;

namespace EXER_05.AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int sum = Sum(firstNumber, secondNumber, thirdNumber);


            Console.WriteLine(sum);

        }

        private static int Sum(int firstNumber, int secondNumber, int thirdNumber)
        {
            int sumFirsAndSecond = firstNumber + secondNumber;

            return Subtract(sumFirsAndSecond, thirdNumber);

        }

        private static int Subtract(int sumFirsAndSecond, int thirdNumber)
        {
            return sumFirsAndSecond - thirdNumber;
        }
    }
}
