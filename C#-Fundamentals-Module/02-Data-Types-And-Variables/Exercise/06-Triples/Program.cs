using System;

namespace EXER_06.Triples
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            for (int a = 97; a <= 97 + n - 1; a++)
            {
                for (int b = 97; b <= 97 + n -1; b++)
                {
                    for (int c = 97; c <= 97 + n - 1; c++)
                    {
                        Console.WriteLine($"{(char)a}{(char)b}{(char)c}");
                    }
                }
            }
        }
    }
}
