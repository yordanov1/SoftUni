using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace LAB_1_ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();            

            while (input != "end")
            {
                List<char> text = new List<char>();
                List<char> reverse = new List<char>();

                for (int i = 0; i < input.Length; i++)
                {
                    text.Add(input[i]);
                }

                for (int i = 0; i < input.Length; i++)
                {
                    reverse.Add(input[i]);
                }

                reverse.Reverse();

                Console.WriteLine($"{string.Join("", text)} = {string.Join("", reverse)}");

                input = Console.ReadLine();
            }          
        }
    }
}
