using System;
using System.Numerics;

namespace EXER_11.SnowBall
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            BigInteger bestValue = 0;
            int bestSnow = 0;
            int bestTime = 0;
            int bestQuality = 0;


            for (int i = 1; i <= n; i++)
            {

                int ballSnow = int.Parse(Console.ReadLine());
                int ballTime = int.Parse(Console.ReadLine());
                int ballQuality = int.Parse(Console.ReadLine());

                int ballSnowTime = ballSnow / ballTime;
                BigInteger ballValue = BigInteger.Pow(ballSnowTime,ballQuality);

                if(bestValue < ballValue)
                {
                    bestValue = ballValue;
                    bestSnow = ballSnow;
                    bestTime = ballTime;
                    bestQuality = ballQuality;
                }

            }

            Console.WriteLine($"{bestSnow} : {bestTime} = {bestValue} ({bestQuality})");
        }
    }
}
