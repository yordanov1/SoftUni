using System;

namespace LAB_02.ReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }

            int key = 0;
            int[] arrReverse = new int[arr.Length];

            for (int i = arr.Length - 1; i >= 0; i--)
            {                
                arrReverse[key] = arr[i];
                
                Console.Write(arrReverse[key] + " ");
                key = key + 1;
            }
        }

    }
}
