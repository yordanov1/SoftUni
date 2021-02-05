using System;
using System.Collections.Generic;
using System.Linq;

namespace _5_WordFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
                                        .Split()
                                        .Where(i => i.Length % 2 == 0)
                                        .ToList();

            Console.WriteLine(string.Join(Environment.NewLine,words));
        }
    }
}
