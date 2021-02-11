﻿using System;

namespace LAB_3_Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();

            int index = text.IndexOf(word);

            while (index >= 0)
            {
                text = text.Remove(index, word.Length);
                index = text.IndexOf(word);
            }

            Console.WriteLine(text);
        }
    }
}
