namespace _01.BinarySearch
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var number = int.Parse(Console.ReadLine());

            Console.WriteLine(BinarySearching(numbers, number));
        }

        private static int BinarySearching(int[] numbers, int number)
        {
            var left = 0;
            var right = numbers.Length - 1;

            while (left <= right)
            {
                var mid = (left + right) / 2;

                if (numbers[mid] == number)
                {
                    return mid;
                }

                if (number > numbers[mid])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1;
        }
    }
}
