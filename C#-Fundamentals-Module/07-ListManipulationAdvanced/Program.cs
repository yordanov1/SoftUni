using System;
using System.Collections.Generic;
using System.Linq;

namespace LAB_07.ListManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<string> command = Console.ReadLine().Split().ToList();

            while (command[0] != "end")
            {
                if (command.Count-1 == 1)
                {
                    if (list.Contains(int.Parse(command[1])))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (command.Count - 1 == 2)
                {
                    if (command.Contains("Filter") && command.Contains(">="))
                    {
                        List<int> bigger = new List<int>();

                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] >= int.Parse(command[2]))
                            {
                                bigger.Add(list[i]);
                            }
                        }
                        
                        Console.WriteLine(string.Join(" ", bigger));
                    }

                    if (command.Contains("Filter") && command.Contains("<"))
                    {
                        List<int> smaller = new List<int>();

                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] < int.Parse(command[2]))
                            {
                                smaller.Add(list[i]);
                            }
                        }
                        Console.WriteLine(string.Join(" ", smaller));
                    }
                }
                else
                {
                    if (command.Contains("PrintEven"))
                    {
                        List<int> even = new List<int>();
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] % 2 == 0)
                            {
                                even.Add(list[i]);
                            }
                        }
                        Console.WriteLine(string.Join(" ", even));
                    }

                    if (command.Contains("PrintOdd"))
                    {
                        List<int> odd = new List<int>();
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] % 2 == 1)
                            {
                                odd.Add(list[i]);
                            }
                        }
                        Console.WriteLine(string.Join(" ", odd));
                    }

                    if (command.Contains("GetSum"))
                    {
                        int sum = list.Sum();
                        Console.WriteLine(sum);
                    }
                }

                command = Console.ReadLine().Split().ToList();
            }        
        }
    }
}
