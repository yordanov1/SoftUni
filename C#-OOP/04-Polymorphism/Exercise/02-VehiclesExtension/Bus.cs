
using System;
using System.Collections.Generic;
using System.Text;

namespace Exer_02.VehiclesExtension
{
    class Bus : Vehicle
    {
        private const double BusAirConditionersModifier = 1.4;

        public Bus(double fuel, double fuelConsumption, double tankCapacity)
            :base(fuel, fuelConsumption, BusAirConditionersModifier, tankCapacity)
        {

        }

        public void TurnOnAirConditioner()
        {
            this.AirConditionersModifier = BusAirConditionersModifier;
        }

        public void TurnOffAirConditioner()
        {
            this.AirConditionersModifier = 0;
        }
    }
}
