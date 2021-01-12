using System;

namespace EXER_01.Wagon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] wagon = new int[n];

            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                wagon[i] = int.Parse(Console.ReadLine());

                sum += wagon[i];

            }

            Console.WriteLine(string.Join(" ", wagon));

            Console.WriteLine(sum);
        }
    }
}
