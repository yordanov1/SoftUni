using System;

namespace _04.BackIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int allInMinutes = hours * 60 + minutes + 30;

            int newHours = allInMinutes / 60;
            int newMinutes = allInMinutes % 60;           

            if(newHours <= 23)
            {
                Console.WriteLine($"{newHours}:{newMinutes:d2}");

            }
            else if(newHours > 23)
            {
                newHours = newHours - 24;

                Console.WriteLine($"{newHours}:{newMinutes:d2}");


            }



        }
    }
}
