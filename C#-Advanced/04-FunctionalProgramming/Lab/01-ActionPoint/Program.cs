using System;
using System.Collections.Generic;
using System.Linq;

namespace FunctionalProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputNUmbers = Console.ReadLine()
                                            .Split(", ", StringSplitOptions.RemoveEmptyEntries)                                            
                                            .Select(int.Parse)  
                                            .Where(x => x % 2 == 0)
                                            .OrderBy(n => n)
                                            .ToList();         

            Console.WriteLine(string.Join(", ", inputNUmbers));

        }
    }
}
