using System;
using System.Collections.Generic;
using System.Text;

namespace Exer_01.Vehicles
{
    public class Truck : Vehicle
    {
        private const double TruckAirConditionersModifier = 1.6;

        public Truck(double fuel, double fuelConsumption)
            :base(fuel, fuelConsumption, TruckAirConditionersModifier)
        {

        }

        public override void Refuel(double amount)
        {
            base.Refuel(amount * 0.95);
        }
    }
}
