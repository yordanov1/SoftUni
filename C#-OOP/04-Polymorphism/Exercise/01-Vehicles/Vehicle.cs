using System;
using System.Collections.Generic;
using System.Text;

namespace Exer_01.Vehicles
{
    public abstract class Vehicle
    {

        public Vehicle(double fuel, double fuelConsumption, double airConditionersModifier )
        {
            this.Fuel = fuel;
            this.FuelConsumption = fuelConsumption;
            this.AirConditionersModifier = airConditionersModifier;
        }

        private double AirConditionersModifier { get; set; }
        public double Fuel { get; private set; }
        public double FuelConsumption { get; private set; }


        public void Drive(double distance)
        {
            double requiredFuel = (this.FuelConsumption + this.AirConditionersModifier) * distance;

            if (requiredFuel > this.Fuel)
            {
                throw new InvalidOperationException($"{this.GetType().Name} needs refueling");
            }

            this.Fuel -= requiredFuel;
        }

        public virtual void Refuel(double amount)
        {
            this.Fuel += amount;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.Fuel:f2}";
        }
    }
}
