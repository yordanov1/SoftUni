using System;
using System.Linq;

namespace EXER_08.MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                int current = arr[i];

                for (int j = i + 1 ; j < arr.Length; j++)
                {
                    int switcher = arr[j];


                    if(current + switcher == number)
                    {

                        Console.WriteLine($"{current} {switcher}");
                    }
                }
            }
        }
    }
}
