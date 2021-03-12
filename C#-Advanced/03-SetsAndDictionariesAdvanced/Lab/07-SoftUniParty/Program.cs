using System;
using System.Collections.Generic;

namespace Lab_07.SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vipGuests = new HashSet<string>();
            HashSet<string> regularGuests = new HashSet<string>();

            string input = Console.ReadLine();

            while (input != "PARTY")
            {
                if (input[0] == '1' || input[0] == '2' || input[0] == '3' 
                                    || input[0] == '4' || input[0] == '5' 
                                    || input[0] == '6' || input[0] == '6'
                                    || input[0] == '7' || input[0] == '8'
                                    || input[0] == '9' || input[0] == '0')
                {
                    vipGuests.Add(input);
                }
                else
                {
                    regularGuests.Add(input);
                }

                input = Console.ReadLine();
            }

            string secondInput = Console.ReadLine();

            while (secondInput != "END")
            {
                if (secondInput[0] == '1' || secondInput[0] == '2' || secondInput[0] == '3'
                                          || secondInput[0] == '4' || secondInput[0] == '5'
                                          || secondInput[0] == '6' || secondInput[0] == '6'
                                          || secondInput[0] == '7' || secondInput[0] == '8'
                                          || secondInput[0] == '9' || secondInput[0] == '0')
                {
                    vipGuests.Remove(secondInput);
                }
                else
                {
                    regularGuests.Remove(secondInput);
                }
                secondInput = Console.ReadLine();
            }

            int guestsCount = vipGuests.Count + regularGuests.Count;

            Console.WriteLine(guestsCount);

            foreach (var vip in vipGuests)
            {
                Console.WriteLine(vip);
            }
            foreach (var regular in regularGuests)
            {
                Console.WriteLine(regular);
            }

        }
    }
}
