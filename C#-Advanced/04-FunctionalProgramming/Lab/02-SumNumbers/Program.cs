using System;
using System.Linq;

namespace Lab_02.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                                 .Split(", ")
                                 .Select(ParsNumber)
                                 .ToArray();
             
            Printresults(array, GetCount, Sum);
        }


        static int GetCount(int[] arrayy)
        {
            return arrayy.Length;
        }

        static int Sum(int[] array)
        {
            return array.Sum();
        }

        static void Printresults(int[] array,
                            Func<int[], int> count,
                            Func<int[], int> sum)
        {
            Console.WriteLine(count(array));
            Console.WriteLine(sum(array));
        }

        static int ParsNumber (string number)
        {
            return int.Parse(number);
        }
    }
}
