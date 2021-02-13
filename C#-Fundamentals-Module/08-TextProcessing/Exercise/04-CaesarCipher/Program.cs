using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EXER_4._CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder shifterText = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                shifterText.Append((char)(text[i] + 3));
            }

            Console.WriteLine(shifterText);
        }
    }
}
