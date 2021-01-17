using System;

namespace EXER_01.Smallest
{
    class Program
    {
        
        static void Main(string[] args)
        {
            decimal one = decimal.Parse(Console.ReadLine());
            decimal two = decimal.Parse(Console.ReadLine());
            decimal three = decimal.Parse(Console.ReadLine());

            SmallestNumber(one, two, three);
        }

        private static void SmallestNumber(decimal one, decimal two, decimal three)
        {
            if (one < two && one < three)
            {
                Console.WriteLine(one);
            }
            else if (two < one && two < three)
            {
                Console.WriteLine(two);
            }
            else if (three < one && three < two)
            {
                Console.WriteLine(three);
            }
            else
            {
                Console.WriteLine(one);
            }

        }
    }
}
