using System;
using System.Collections.Generic;
using System.Linq;

namespace EXER_06.CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> playerONE = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> playerTWO = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (playerONE.Count != 0 && playerTWO.Count != 0 )
            {
                if (playerONE[0] > playerTWO[0])
                {
                    playerONE.Add(playerONE[0]);
                    playerONE.Add(playerTWO[0]);
                    playerONE.RemoveAt(0);
                    playerTWO.RemoveAt(0);
                }
                else if(playerONE[0] < playerTWO[0])
                {
                    playerTWO.Add(playerTWO[0]);
                    playerTWO.Add(playerONE[0]);
                    playerONE.RemoveAt(0);
                    playerTWO.RemoveAt(0);
                }
                else if (playerONE[0] == playerTWO[0])
                {
                    playerONE.RemoveAt(0);
                    playerTWO.RemoveAt(0);
                }
            }

            if (playerONE.Count != 0)
            {
                int sum = playerONE.Sum();
                Console.WriteLine($"First player wins! Sum: {sum}");
            }
            else
            {
                int sum = playerTWO.Sum();
                Console.WriteLine($"Second player wins! Sum: {sum}");
            }          
        }
    }
}
