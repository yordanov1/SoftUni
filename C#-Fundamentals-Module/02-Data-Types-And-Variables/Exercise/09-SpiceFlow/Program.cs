using System;
using System.Numerics;

namespace EXER_09.SpiceFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger startingYield = BigInteger.Parse(Console.ReadLine());            
            BigInteger profit = 0;
            BigInteger count = 0;

            if (startingYield < 100)
            {
                Console.WriteLine(count);
                Console.WriteLine(profit);
            }
            else
            {
                while (startingYield >= 100)
                {

                    profit = profit + startingYield - 26;

                    startingYield = startingYield - 10;

                    count++;

                }

                profit -= 26;

                Console.WriteLine(count);
                Console.WriteLine(profit);
            }


        }
    }
}
