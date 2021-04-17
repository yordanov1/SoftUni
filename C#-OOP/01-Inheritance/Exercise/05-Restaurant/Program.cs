using System;

namespace Restaurant
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Cake cake = new Cake("Lorincano");

            Console.WriteLine(cake.Grams);
        }
    }
}
