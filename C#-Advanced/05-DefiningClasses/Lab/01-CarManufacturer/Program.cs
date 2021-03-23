using System;

namespace CarManufacturer
{
    public class  StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Make = "hop";
            car.Year = 55;
            car.Model = "X3";
            Console.WriteLine($"{car.Make} - {car.Model} - {car.Year}");
        }
    }
}
