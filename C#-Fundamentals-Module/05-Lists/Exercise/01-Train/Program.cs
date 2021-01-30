using System;
using System.Collections.Generic;
using System.Linq;

namespace EXER_01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxPassengers = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            while (command != "end")
            {
                List<string> comandSEP = command.Split().ToList();

                    if (comandSEP[0] == "Add")
                    {
                        int newVagon = int.Parse(comandSEP[1]);
                        wagons.Add(newVagon);
                    }
                    else
                    {
                        int passengers = int.Parse(comandSEP[0]);

                       for (int i = 0; i < wagons.Count; i++)
                       {                       
                          if ((wagons[i] + passengers) <= maxPassengers)
                          {
                            wagons[i] += passengers;
                            break;
                          }
                       }
                    }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
