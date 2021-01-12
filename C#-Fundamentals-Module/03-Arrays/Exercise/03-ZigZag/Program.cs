using System;
using System.Linq;

namespace EXER_03.ZigZag
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr1 = new int[n];
            int[] arr2 = new int[n];

            int a1 = 0;
            int a2 = 0;

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if(i % 2 == 0)
                {
                    a1 = 0;
                    a2 = 1;
                }
                else
                {
                    a1 = 1;
                    a2 = 0;
                }
                
                arr1[i] = input[a1];
                arr2[i] = input[a2];
            }

            Console.WriteLine(string.Join(" ", arr1));
            Console.WriteLine(string.Join(" ", arr2));
        }
    }
}
