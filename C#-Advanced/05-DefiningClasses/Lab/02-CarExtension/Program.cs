using Lab_02.CarExtension;
using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Car truck = new Car();

            truck.Make = "MAN";
            truck.Year = 10;
            truck.Model = "G5";
            Console.WriteLine($"{truck.Make} - {truck.Model} - {truck.Year}");

            truck.FuelConsumption = 20;
            truck.FuelQuantity = 300;
            truck.Drive(30);
            Console.WriteLine(truck.WhoAmI());


            car.Make = "hop";
            car.Year = 55;
            car.Model = "X3";
            Console.WriteLine($"{car.Make} - {car.Model} - {car.Year}");

            car.FuelConsumption = 12;
            car.FuelQuantity = 200;

            car.Drive(20);
            car.Drive(10);
            Console.WriteLine(car.WhoAmI());    
        }      
    }
}
