using System;
using System.Linq;

namespace LAB_04.ReversString2
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] entryTwo = Console.ReadLine().Split();

            string[] entryThree = new string[entryTwo.Length];

            int key = 0;

            for (int i = entryTwo.Length - 1 ; i >= 0; i--)
            {
                entryThree[key] = entryTwo[i];

                Console.Write(entryThree[key] + " ");

                key += 1;
            }
        }
    }
}
