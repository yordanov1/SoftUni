using System;

namespace _07.TheatrePromotions
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            if(age >= 0 && age <= 18)
            {
                if(day == "Weekday")
            }


           
        }
    }
}



//Day / Age	           0 <= age <= 18	  18 < age <= 64	   64 < age <= 122
//  Weekday                12$              	18$             	12$
//  Weekend                15$	                20$	                15$
//  Holiday                 5$	                12$	                10$
