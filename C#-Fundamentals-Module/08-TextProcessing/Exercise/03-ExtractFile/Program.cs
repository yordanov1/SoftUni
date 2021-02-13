using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EXER_3_ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> directory = Console.ReadLine().Split("\\").ToList();
            List<string> lastTwo = directory[directory.Count - 1].Split(".").ToList();

            Console.WriteLine($"File name: {lastTwo[0]}");
            Console.WriteLine($"File extension: {lastTwo[1]}");            
        }
    }
}
