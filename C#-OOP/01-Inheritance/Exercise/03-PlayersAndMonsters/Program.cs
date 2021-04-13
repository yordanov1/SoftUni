using System;

namespace PlayersAndMonsters
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero("Jony", 99);

            Console.WriteLine(hero);
        }
    }
}
