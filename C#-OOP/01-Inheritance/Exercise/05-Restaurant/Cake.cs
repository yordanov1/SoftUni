using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Cake : Dessert
    {
        private const double gramsCake = 250;
        private const double caloriesCake = 1000;
        private const decimal priceCake = 5m;

        public Cake(string name)
            : base(name, priceCake, gramsCake, caloriesCake)
        {
        }
    }
}
