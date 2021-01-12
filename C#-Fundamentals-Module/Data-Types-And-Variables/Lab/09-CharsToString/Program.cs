using System;

namespace LAB_09.CharsToString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = String.Empty;

            for (int i = 1; i <=3 ; i++)
            {
                char symbol = char.Parse(Console.ReadLine());

                text += symbol;
            }

            Console.WriteLine(text);
        }
    }
}
