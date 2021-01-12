using System;

namespace EXER_08.BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string Biggest = String.Empty;

            double bigger = 0;


            for (int i = 1; i <= n; i++)
            {
                string text = Console.ReadLine();
                double r = double.Parse(Console.ReadLine());
                int h = int.Parse(Console.ReadLine());

                double volume = Math.PI * r * r * h;

                if(volume > bigger)
                {
                    bigger = volume;
                    Biggest = text;
                }

            }

            Console.WriteLine(Biggest);
        }
    }
}
