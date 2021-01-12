using System;
using System.Globalization;

namespace EXER_02.CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] arrOne = Console.ReadLine().Split();
            string[] arrTwo = Console.ReadLine().Split();

            for (int i = 0; i < arrTwo.Length; i++)
            {
                for (int j = 0; j < arrOne.Length; j++)
                {
                    if (arrTwo[i] == arrOne[j])
                    {
                        Console.Write(arrTwo[i] + " ");
                    }

                }
            }
          
        }
    }
}
