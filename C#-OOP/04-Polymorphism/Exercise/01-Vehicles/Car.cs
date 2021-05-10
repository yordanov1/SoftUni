using System;
using System.Collections.Generic;
using System.Text;

namespace Exer_01.Vehicles
{
    public class Car : Vehicle
    {
        private const double CarAirConditionersModifier = 0.9;

        public Car(double fuel, double fuelConsumption)
            :base(fuel, fuelConsumption, CarAirConditionersModifier)
        {

        }
    }
}
