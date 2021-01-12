using System;

namespace EXER_09.PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double priceLightsaber = double.Parse(Console.ReadLine());
            double priceRobe = double.Parse(Console.ReadLine());
            double priceBelt = double.Parse(Console.ReadLine());


            double countSabres = Math.Ceiling(students * 1.1);
            int freeBelts = students / 6;

            double lightsaberAll = countSabres * priceLightsaber;
            double robesAll = students * priceRobe;
            double beltsAll = (students - freeBelts) * priceBelt;

            double all = lightsaberAll + robesAll + beltsAll;

            if(money >= all)
            {
                Console.WriteLine($"The money is enough - it would cost {all:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {(all - money):f2}lv more.");
            }
        }
    }
}
