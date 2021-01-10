using System;

namespace MORE_05.DecriptingMesseges
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            string all = String.Empty;

            for (int i = 1; i <= n; i++)
            {

                char symbol = char.Parse(Console.ReadLine());

                int useKey = (int)symbol + key;

                char output = (char)useKey;

                all = all + output;


            }
            Console.WriteLine(all);
        }
    }
}
