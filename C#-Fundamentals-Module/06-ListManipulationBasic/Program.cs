using System;
using System.Collections.Generic;
using System.Linq;

namespace LAB_06.ListManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<string> command = Console.ReadLine().Split().ToList();

            while (command[0] != "end")
            {
                
                if (command.Contains("Add"))
                {
                    command.Remove("Add");
                  
                        input.Add(int.Parse(command[0]));
                    
                }
                else if (command.Contains("Remove"))
                {
                    command.Remove("Remove");
                    
                        input.Remove(int.Parse(command[0]));
                    
                }
                else if (command.Contains("RemoveAt"))
                {
                    command.Remove("RemoveAt");

                    
                        input.RemoveAt(int.Parse(command[0]));
                    
                }
                else if (command.Contains("Insert"))
                {
                    command.Remove("Insert");

                    
                        input.Insert(int.Parse(command[1]),int.Parse(command[0]));
                    
                }

                command = Console.ReadLine().Split().ToList();

            }
            Console.WriteLine(string.Join(" ", input));

        }
    }
}
