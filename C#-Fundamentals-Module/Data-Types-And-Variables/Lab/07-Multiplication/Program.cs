using System;

namespace LAB_07.Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int multiplayer = int.Parse(Console.ReadLine());

            if(multiplayer <= 10)
            {
                for (int i = multiplayer + 1; multiplayer <= 10; multiplayer++)
                {
                    int sum = number * multiplayer;

                    Console.WriteLine($"{number} X {multiplayer} = {sum}");
                }
            }
            else
            {
                int sumOne = number * multiplayer;

                Console.WriteLine($"{number} X {multiplayer} = {sumOne}");
            }
            
        }
    }
}
