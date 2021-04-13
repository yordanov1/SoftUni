using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{   
    public class Car : Vehicle
    {
        private const double DefaultFuelConsumption = 3.0;

        public Car(int horsePower, double fuel) 
            : base(horsePower, fuel)
        {
        }

        public override double FuelConsumption => DefaultFuelConsumption;
    }
}
