using System;
using System.Collections;
using System.Collections.Generic;


namespace Lab_08.TrafficJam_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int passingCars = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            Queue<string> queue = new Queue<string>();

            int counter = 0;

            while (input != "end")
            {
                int count = queue.Count;

                if (input == "green")
                {
                    if (queue.Count >= passingCars)
                    {
                        for (int i = 0; i < passingCars; i++)
                        {
                            Console.WriteLine($"{queue.Dequeue()} passed!");
                            counter++;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < count; i++)
                        {
                            Console.WriteLine($"{queue.Dequeue()} passed!");
                            counter++;                           
                        }             
                    }
                }
                else
                {
                    queue.Enqueue(input);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}
