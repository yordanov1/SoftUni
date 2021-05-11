using CarManager;
using NUnit.Framework;
using System;

namespace Tests
{
    public class CarTests
    {
        private Car car;

        [SetUp]
        public void Setup()
        {
            this.car = new Car("Make", "Model", 10, 100);
        }

        [Test]
        [TestCase("", "Model", 10, 100)]
        [TestCase(null, "Model", 10, 100)]
        [TestCase("Make", "", 10, 100)]
        [TestCase("Make", null, 10, 100)]
        [TestCase("Make", "Model", 0, 100)]
        [TestCase("Make", "Model", -10, 100)]
        [TestCase("Make", "Model", 10, 0)]
        [TestCase("Make", "Model", 10, -50)]
        public void Ctor_ThrowsException_WhenDataIsInvalid(string make, string model, double fuelConsumption, double fuelCapacity)
        {
            Assert.Throws<ArgumentException>(() => new Car(make, model, fuelConsumption, fuelCapacity));
        }

        [Test]
        public void Ctor_SetInitialValues_WhenArgumentAreValid()
        {
            string make = "Make";
            string model = "MOdel";
            double fuelConsumption = 10.0;
            double fuelCapacity = 100.0;

            Car car = new Car(make, model, fuelConsumption, fuelCapacity);

            Assert.That(car.Make, Is.EqualTo(make));
            Assert.That(car.Model, Is.EqualTo(model));
            Assert.That(car.FuelConsumption, Is.EqualTo(fuelConsumption));
            Assert.That(car.FuelCapacity, Is.EqualTo(fuelCapacity));
        }

        [Test]
        [TestCase(-20)]
        public void Refuel_ThrowsException_WhenFuelIsZeroOrNegative(double fuel)
        {
            Assert.Throws<ArgumentException>(() => car.Refuel(fuel));
        }

        [Test]
        public void Refuel_IncreasesFuelAmount()
        {
            double refuelAmount = this.car.FuelCapacity / 2;

            this.car.Refuel(refuelAmount);

            Assert.That(this.car.FuelAmount, Is.EqualTo(refuelAmount));
        }

        [Test]
        public void Refuel_SetFuelAmountToCapacity_WhenCapacityIsExceeded()
        {
            this.car.Refuel(this.car.FuelCapacity * 1.2);

            Assert.That(this.car.FuelAmount, Is.EqualTo(this.car.FuelCapacity));
        }

        [Test]
        public void Drive_ThrowsException_WhenFuelIsZero()
        {
            Assert.Throws<InvalidOperationException>(() => this.car.Drive(100));
        }

        [Test]
        public void Drive_DecreasesFuelAmount_WhenDistanceIsValid()
        {
            double initialkFuel = this.car.FuelCapacity;

            this.car.Refuel(initialkFuel);

            this.car.Drive(100);

            Assert.That(this.car.FuelAmount, Is.EqualTo(initialkFuel - this.car.FuelConsumption));
        }

        [Test]
        public void Drive_DecreasesFuelAmount_WhenRequiredFuelIsEqualToFuelAmount()
        {
            this.car.Refuel(this.car.FuelCapacity);

            double distance = this.car.FuelCapacity * this.car.FuelConsumption;

            this.car.Drive(distance);

            Assert.That(this.car.FuelAmount, Is.EqualTo(0));
        }
        
        [Test]
        public void FuelAmount_ThrowsException_WhenNegativeValueIsPassed() 
        {
            this.car.Refuel(this.car.FuelCapacity);

            double beforeDrive = this.car.FuelAmount;

            this.car.Drive(100);

            double afterDrive = this.car.FuelAmount;

            Assert.That(afterDrive, Is.LessThan(beforeDrive));
        }        
    }
}