using System;
using System.Collections.Generic;
using System.Text;

namespace Exer_02.GenericBoxОfInteger
{
    public class Box<T>
    {
        public Box(T value)
        {
            this.Valye = value;
        }
        public T Valye { get; set; }

        public override string ToString()
        {
            return $"{this.Valye.GetType()}: {this.Valye}";
        }
    }
}
