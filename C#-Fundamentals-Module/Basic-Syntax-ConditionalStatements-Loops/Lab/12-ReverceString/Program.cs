using System;

namespace MORE_04.ReverceString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string reverse = String.Empty;

            for (int i = text.Length - 1; i >= 0; i--)
            {
                reverse = reverse + text[i];
            }

            Console.WriteLine(reverse);
        }
    }
}
