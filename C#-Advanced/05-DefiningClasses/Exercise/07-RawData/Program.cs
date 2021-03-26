using System;
using System.Collections.Generic;
using System.Linq;

namespace Exer_07.RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();             

            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {

                string[] input = Console.ReadLine()
                                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                        .ToArray();

                string model = input[0];
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);
                int cargoWeight = int.Parse(input[3]); string cargoType = input[4];

                double tire1Pressure = double.Parse(input[5]);    int tire1Age = int.Parse(input[6]);
                double tire2Pressure = double.Parse(input[7]);    int tire2Age = int.Parse(input[8]);
                double tire3Pressure = double.Parse(input[9]);    int tire3Age = int.Parse(input[10]);
                double tire4Pressure = double.Parse(input[11]);   int tire4Age = int.Parse(input[12]);

                Model modelType = new Model(model);
                Cargo cargo = new Cargo(cargoType);
                Engine engine = new Engine(enginePower);
                Tire tire = new Tire(tire1Pressure, tire2Pressure, tire3Pressure, tire4Pressure);

                Car car = new Car(modelType, cargo, engine, tire);

                cars.Add(car);
            }

            string command = Console.ReadLine();

            foreach (var car in cars)
            {
                if (command == "fragile")
                {
                    if (car.Tire.Tire1Pressure < 1 || car.Tire.Tire2Pressure < 1 
                     || car.Tire.Tire3Pressure < 1 || car.Tire.Tire4Pressure < 1 && car.Cargo.CargoType == "fragile")
                    {
                        Console.WriteLine(car.Model.ModelType);
                    }
                }
                else if (command == "flamable")
                {
                    if (car.Engine.EnginePower > 250 && car.Cargo.CargoType == "flamable")
                    {
                        Console.WriteLine(car.Model.ModelType);
                    }
                }
            }            
        }
    }
}
