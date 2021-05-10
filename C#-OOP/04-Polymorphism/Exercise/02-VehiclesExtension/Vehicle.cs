using System;
using System.Collections.Generic;
using System.Text;

namespace Exer_02.VehiclesExtension
{
    public abstract class Vehicle
    {
        private double fuel;
        public Vehicle(double fuel, double fuelConsumption, double airConditionersModifier, double tankCapacity )
        {
            this.TankCapacity = tankCapacity;
            this.Fuel = fuel;
            this.FuelConsumption = fuelConsumption;
            this.AirConditionersModifier = airConditionersModifier;
        }

        protected double AirConditionersModifier { get; set; }
        public double Fuel 
        {
            get => this.fuel;
            protected set
            {
                if (value > this.TankCapacity)
                {
                    this.fuel = 0;
                }
                else
                {
                    this.fuel = value;
                }
            }
        }
        public double FuelConsumption { get; private set; }
        public double TankCapacity { get; private set; }


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
            if (amount <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }

            if (this.Fuel + amount > this.TankCapacity)
            {
                throw new InvalidOperationException($"Cannot fit {amount} fuel in the tank");
            }

            this.Fuel += amount;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.Fuel:f2}";
        }
    }
}
