using System;
using System.Linq;

namespace LAB_03.Round
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] number = Console.ReadLine().Split().Select(double.Parse).ToArray();
           
            int[] round = new int[number.Length];

            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] == -0)
                {
                    number[i] = 0;
                }
                round[i] = (int)Math.Round(number[i], MidpointRounding.AwayFromZero);

                Console.WriteLine($"{number[i]} => {round[i]}");
            }            
        }
    }
}
