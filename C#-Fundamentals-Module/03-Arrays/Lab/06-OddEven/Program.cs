using System;
using System.Linq;

namespace LAB_06.OddEven
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sumOdd = 0;
            int sumEven = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] % 2 == 0)
                {
                    sumEven += arr[i];
                }
                else
                {
                    sumOdd += arr[i];
                }
            }

            Console.WriteLine(sumEven - sumOdd);
        }
    }
}
