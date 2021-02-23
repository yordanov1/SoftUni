using System;
using System.Collections.Generic;

namespace Lab_06.Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string incomingPeople = Console.ReadLine();

            Queue<string> peopleOnQueue = new Queue<string>();

            while (incomingPeople != "End")
            {
                if (incomingPeople == "Paid")
                {
                    foreach (var item in peopleOnQueue)
                    {
                        Console.WriteLine(item);
                    }
                    peopleOnQueue.Clear();
                }
                else
                {
                    peopleOnQueue.Enqueue(incomingPeople);
                }

                incomingPeople = Console.ReadLine();
            }

            Console.WriteLine($"{peopleOnQueue.Count} people remaining.");
        }
    }
}
