using System;

namespace LAB_10.LowerUper
{
    class Program
    {
        static void Main(string[] args)
        {
            string character = Console.ReadLine();
            string lowerCharacter = character.ToLower();

            if (character == lowerCharacter)
            {
                Console.WriteLine("lower-case");
            }
            else if (character != lowerCharacter)
            {
                Console.WriteLine("upper-case");
            }
        }

    }
}
