using System;

namespace EXER_03.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            double persons = double.Parse(Console.ReadLine());
            double places = double.Parse(Console.ReadLine());

            double lower = Math.Floor(persons / places);
            double last = persons - (lower * places);
            int one = 1;
            



            if((persons == places) || (persons < places))
            {
                // Console.WriteLine($"All the persons fit inside in the elevator.Only one course is needed.");
                Console.WriteLine("1");
            }
            else if ((persons / places)-lower > 0)
            {
                //Console.WriteLine($"{lower} courses * {places} people + 1 course * {last} persons");
                Console.WriteLine($"{lower + one}");
            }
            else
            {
                //Console.WriteLine($"{lower} courses * {places} people");
                Console.WriteLine($"{lower}");
            }
            
            


        }
    }
}
