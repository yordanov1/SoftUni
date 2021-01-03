using System;

namespace EXER_05.PrintASCII
{
    class Program
    {
        static void Main(string[] args)
        {

            int beginning = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = beginning; beginning <=end ; beginning++)
            {
                Console.Write($"{(char)beginning} ");

            }
        }
    }
}
