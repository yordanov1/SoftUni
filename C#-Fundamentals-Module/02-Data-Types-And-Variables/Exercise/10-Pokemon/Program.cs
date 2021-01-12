using System;

namespace EXER_10.Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());

            int counter = 0;
            double tempPower = N * 0.5;

            while(N >= M)
            {
                counter++;
                N = N - M;
                
                if(N == tempPower && Y != 0)
                {
                    N = N / Y;
                }
            }

            Console.WriteLine(N);
            Console.WriteLine(counter);
        }
    }
}
