
using System;

namespace Exer_02.VehiclesExtension
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Vehicle car = CreateVehichele();
            Vehicle truck = CreateVehichele();
            Vehicle bus = CreateVehichele();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] parts = Console.ReadLine().Split();

                string command = parts[0];
                string vehicheleType = parts[1];
                double parameter = double.Parse(parts[2]);

                try
                {
                    if (vehicheleType == nameof(Car))
                    {
                        ProcessCommand(car, command, parameter);
                    }
                    else if (vehicheleType == nameof(Bus))
                    {
                        ProcessCommand(bus, command, parameter);
                    }
                    else
                    {
                        ProcessCommand(truck, command, parameter);
                    }
                }
                catch (Exception ex)
                when (ex is InvalidOperationException || ex is ArgumentException)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }

        private static void ProcessCommand(Vehicle vehicle, string command, double parameter)
        {
            if (command == "Drive")
            {
                vehicle.Drive(parameter);

                Console.WriteLine($"{vehicle.GetType().Name} travelled {parameter} km");
            }
            else if (command == "DriveEmpty")
            {

                ((Bus)vehicle).TurnOffAirConditioner();

                vehicle.Drive(parameter);

                ((Bus)vehicle).TurnOnAirConditioner();

                Console.WriteLine($"{vehicle.GetType().Name} travelled {parameter} km");
            }
            else
            {
                vehicle.Refuel(parameter);
            }
        }

        private static Vehicle CreateVehichele()
        {
            string[] parts = Console.ReadLine().Split();

            string type = parts[0];
            double fuelQuantity = double.Parse(parts[1]);
            double fuelConsumption = double.Parse(parts[2]);
            double tankCapacity = double.Parse(parts[3]);

            Vehicle vehicele = null;

            if (type == nameof(Car))
            {
                vehicele = new Car(fuelQuantity, fuelConsumption, tankCapacity);
            }
            else if (type == nameof(Truck))
            {
                vehicele = new Truck(fuelQuantity, fuelConsumption, tankCapacity);
            }
            else if (type == nameof(Bus))
            {
                vehicele = new Bus(fuelQuantity, fuelConsumption, tankCapacity);
            }

            return vehicele;
        }
    }
}
