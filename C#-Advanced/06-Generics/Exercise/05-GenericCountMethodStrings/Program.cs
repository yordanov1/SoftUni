using System;
using System.Collections.Generic;
using System.Linq;

namespace Exer_05.GenericCountMethodStrings
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> elements = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string element = Console.ReadLine();
                elements.Add(element);
            }

            Box<string> box = new Box<string>(elements);

            string elementsToCompare = Console.ReadLine();

            int countOfGreaterElements = box.CountGreaterElements(elements, elementsToCompare);

            Console.WriteLine(countOfGreaterElements);
        }
    }
}
