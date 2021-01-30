using System;
using System.Collections.Generic;
using System.Linq;

namespace EXER_04.ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] command = Console.ReadLine().Split();

            while (command[0] != "End")
            {
                switch (command[0])
                {
                    case "Add":
                        int add = int.Parse(command[1]);
                        numbers.Add(add);
                        break;

                    case "Remove":
                        int del = int.Parse(command[1]);

                        if (del >= 0 && del <= numbers.Count - 1)
                        {
                            numbers.RemoveAt(del);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;

                    case "Insert":
                        int num = int.Parse(command[1]);
                        int index = int.Parse(command[2]);
                        if (index >= 0 && index <= (numbers.Count - 1))
                        {
                            numbers.Insert(index, num);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;

                    case "Shift":
                        if (command[1] == "left")
                        {
                            int n = int.Parse(command[2]);
                            for (int i = 0; i < n; i++)
                            {
                                int left = numbers[0];
                                numbers.Add(left);
                                numbers.Remove(numbers[0]);
                            }
                        }
                        else if (command[1] == "right")
                        {
                            int n = int.Parse(command[2]);
                            for (int i = 0; i < n; i++)
                            {
                                int right = numbers[numbers.Count - 1];
                                numbers.Insert(0, right);
                                numbers.RemoveAt(numbers.Count - 1);
                            }
                        }
                        break;
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}

