using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EXER_6__ReplaceRepeating
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();            

            Console.Write(text[0]);

            for (int i = 1; i < text.Length; i++)
            {
                if (text[i] != text[i - 1])
                {
                    Console.Write(text[i]);
                }
            }
        }
    }
}
