using System;
using System.Collections.Generic;

namespace Exer_06.GenericCountMethod
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<double> elements = new List<double>();

            for (int i = 0; i < n; i++)
            {
                double element = double.Parse(Console.ReadLine());
                elements.Add(element);
            }

            Box<double> box = new Box<double>(elements);

            double elementsToCompare = double.Parse(Console.ReadLine());

            double countOfGreaterElements = box.CountGreaterElements(elements, elementsToCompare);

            Console.WriteLine(countOfGreaterElements);
        }
    }
}
