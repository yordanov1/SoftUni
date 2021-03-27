using System;
using System.Collections.Generic;
using System.Text;

namespace Exer_03.GenericSwapMethod
{
    public class Box<T>
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
    }
}
