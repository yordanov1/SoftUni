using System;

namespace LAB_01.DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = new string[]
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            int dayOfWeek = int.Parse(Console.ReadLine());

            if (dayOfWeek < 1 || dayOfWeek > days.Length )
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                Console.WriteLine(days[dayOfWeek - 1]);
            }
        }
    }
}
