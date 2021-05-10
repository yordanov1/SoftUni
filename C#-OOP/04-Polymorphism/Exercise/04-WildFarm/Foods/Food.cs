using System;
using System.Collections.Generic;
using System.Text;

namespace Exer_04.WildFarm.Foods
{
    public abstract class Food
    {
        protected Food(int quantity)
        {
            Quantity = quantity;
        }

        public int Quantity { get; private set; }
    }
}
