using System;
using System.Collections.Generic;
using System.Text;

namespace Exer_02.VehiclesExtension
{
    public class Car : Vehicle
    {
        private const double CarAirConditionersModifier = 0.9;

        public Car(double fuel, double fuelConsumption, double tankCapacity)
            :base(fuel, fuelConsumption, CarAirConditionersModifier, tankCapacity)
        {

        }
    }
}
