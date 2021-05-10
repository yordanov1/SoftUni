using System;

namespace Exer_01.Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            Vehicle car = CreateVehichele();
            Vehicle truck = CreateVehichele();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] parts = Console.ReadLine().Split();

                string command = parts[0];
                string vehicheleType = parts[1];
                double parameter = double.Parse(parts[2]);

                if (command == "Drive")
                {
                    try
                    {
                        if (vehicheleType == nameof(Car))
                        {
                            car.Drive(parameter);
                        }
                        else
                        {
                            truck.Drive(parameter);
                        }

                        Console.WriteLine($"{vehicheleType} travelled {parameter} km");
                    }
                    catch (InvalidOperationException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                {
                    if (vehicheleType == nameof(Car))
                    {
                        car.Refuel(parameter);
                    }
                    else
                    {
                        truck.Refuel(parameter);
                    }
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
        }

        private static Vehicle CreateVehichele()
        {
            string[] parts = Console.ReadLine().Split();

            string type = parts[0];
            double fuelQuantity = double.Parse(parts[1]);
            double fuelConsumption = double.Parse(parts[2]);

            Vehicle vehichele = null;

            if (type == nameof(Car))
            {
                vehichele = new Car(fuelQuantity, fuelConsumption);
            }
            else if (type == nameof(Truck))
            {
                vehichele = new Truck(fuelQuantity, fuelConsumption);
            }

            return vehichele;
        }
    }
}
