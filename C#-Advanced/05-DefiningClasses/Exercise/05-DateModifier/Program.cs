using System;

namespace Exer_05.DateModifier
{
    public class Program
    {
        static void Main(string[] args)
        {
            string startDate = Console.ReadLine();
            string endDate = Console.ReadLine();

            DateModifier dateModifier = new DateModifier();
            var result = dateModifier.GetDaysDifference(startDate, endDate);
            Console.WriteLine(result);
        }
    }
}
