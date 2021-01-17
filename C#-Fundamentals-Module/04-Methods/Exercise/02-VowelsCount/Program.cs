using System;
using System.Diagnostics.Tracing;

namespace EXER_02.VowelsCount
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            int counter = 0;
            FindTheFinders(input , counter);    
        }

        static void FindTheFinders(string input , int counter)
        {
            counter = 0;

            for (int i = 0; i < input.Length ; i++)
            {
                if (input[i] == 'a' || input[i] == 'e' ||
                    input[i] == 'i' || input[i] == 'o' || 
                    input[i] == 'u' || input[i] == 'y')
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }

    }
}
