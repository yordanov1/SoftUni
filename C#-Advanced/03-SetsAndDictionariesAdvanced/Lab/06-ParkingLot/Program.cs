using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_06.ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> allCarNumbers = new HashSet<string>();

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] numbers = input.Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string direction = numbers[0];
                string number = numbers[1];

                if (direction == "IN")
                {
                    allCarNumbers.Add(number);
                }
                else if (direction == "OUT")
                {
                    allCarNumbers.Remove(number);
                }

                input = Console.ReadLine();
            }

            if (allCarNumbers.Count > 0)
            {
                foreach (var number in allCarNumbers)
                {
                    Console.WriteLine(number);
                }
            }
            else if (allCarNumbers.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
