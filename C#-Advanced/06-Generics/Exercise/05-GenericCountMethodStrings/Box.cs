using System;
using System.Collections.Generic;
using System.Text;

namespace Exer_05.GenericCountMethodStrings
{
    public class Box<T> where T : IComparable
    {
        public Box(List<T> value)
        {
            this.Valye = value;
        }
        public List<T> Valye { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in this.Valye)
            {
                sb.AppendLine($"{item.GetType()}: {item}");
            }

            return sb.ToString().TrimEnd();
        }

        public void Swap(List<T> items, int firstIndex, int secondIndex)
        {
            T tempValue = items[firstIndex];

            items[firstIndex] = items[secondIndex];
            items[secondIndex] = tempValue;
        }

        public int CountGreaterElements(List<T> elements , T elementToCompare)
        {
            int counter = 0;
            foreach (var element in elements)
            {
                if (elementToCompare.CompareTo(element) < 0)
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
