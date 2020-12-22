using System;
using System.Threading;

namespace _03_Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            string tipeOfGroup = Console.ReadLine();
            string day = Console.ReadLine();

            double totalPrice = 0;
            if(tipeOfGroup == "Students")
            {
                if (day == "Friday")
                {
                    totalPrice = numberOfPeople * 8.45;


                }
                else if (day == "Saturday")
                {
                    totalPrice = numberOfPeople * 9.80;
                }
                else if (day == "Sunday")
                {
                    totalPrice = numberOfPeople * 10.46;
                }

                

                if(numberOfPeople >= 30)
                {
                    totalPrice *= 0.85;
                }

            }
            else if( tipeOfGroup == "Business")
            {
                if(numberOfPeople >= 100)
                {
                    numberOfPeople -= 10;
                }

                if ( day == "Friday")
                {
                    totalPrice = numberOfPeople * 10.90;
                }
                else if ( day == "Saturday")
                {
                    totalPrice = numberOfPeople * 15.60;
                }
                else if ( day == "Sunday")
                {
                    totalPrice = numberOfPeople * 16;
                }
            }
            else if (tipeOfGroup == "Regular")
            {
                if(day == "Friday")
                {
                    totalPrice = numberOfPeople * 15;
                }
                else if (day == "Saturday")
                {
                    totalPrice = numberOfPeople * 20;
                }
                else if (day == "Sunday")
                {
                    totalPrice = numberOfPeople * 22.50;
                }

                if(numberOfPeople >= 10 && numberOfPeople <= 20)
                {
                    totalPrice *= 0.95;

                }
            }
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
