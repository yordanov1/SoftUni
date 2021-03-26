using System;
using System.Collections.Generic;
using System.Linq;

namespace Exer_08.CarSalesman
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            List<Engine> engines = new List<Engine>();

            for (int i = 0; i < N; i++)
            {
                List<string> engineProp = Console.ReadLine()
                                                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                                 .ToList();
                
                string model = engineProp[0];
                string power = engineProp[1];
                string displacemen = string.Empty;
                string efficiency = string.Empty;

                if (engineProp.Count == 2)
                {
                    displacemen ="n/a";
                    efficiency = "n/a";
                }
                else if (engineProp.Count == 3)
                {
                    if (engineProp[2].Contains("1") || engineProp[2].Contains("2") || engineProp[2].Contains("3") 
                     || engineProp[2].Contains("4") || engineProp[2].Contains("5") || engineProp[2].Contains("6") 
                     || engineProp[2].Contains("7") || engineProp[2].Contains("8") || engineProp[2].Contains("9") 
                     || engineProp[2].Contains("0"))
                    {
                        displacemen = engineProp[2];
                        efficiency = "n/a";
                    }
                    else
                    {
                        displacemen = "n/a";
                        efficiency = engineProp[2];
                    }
                }
                else
                {
                    displacemen = engineProp[2];
                    efficiency = engineProp[3];
                }

                Engine engin = new Engine(model, power, displacemen, efficiency);
                engines.Add(engin);
            }

            List<Car> cars = new List<Car>();
            
            int M = int.Parse(Console.ReadLine());

            for (int i = 0; i < M; i++)
            {
                List<string> carProp = Console.ReadLine()
                                              .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                              .ToList();

                string model = carProp[0];
                string engine = carProp[1];
                string weight = string.Empty;
                string color = string.Empty;

                if (carProp.Count == 2)
                {
                    weight = "n/a";
                    color = "n/a";
                }
                else if (carProp.Count == 3)
                {

                    if (carProp[2].Contains("1") || carProp[2].Contains("2") || carProp[2].Contains("3")
                     || carProp[2].Contains("4") || carProp[2].Contains("5") || carProp[2].Contains("6")
                     || carProp[2].Contains("7") || carProp[2].Contains("8") || carProp[2].Contains("9")
                     || carProp[2].Contains("0"))
                    {
                        weight = carProp[2];
                        color = "n/a";
                    }
                    else
                    {
                        weight = "n/a";
                        color = carProp[2];
                    }
                }
                else
                {
                    weight = carProp[2];
                    color = carProp[3];
                }

                foreach (var engi in engines)
                {
                    if (engi.Model ==  engine)
                    {
                        Car car = new Car(model, engi, weight, color);

                        cars.Add(car);
                    }
                }
            }


            foreach (var car in cars)
            {                          

                Console.WriteLine($"{car.Model}:" + Environment.NewLine + 
                                  $"{car.Engine.ToString()}" + Environment.NewLine +                                 
                                  $"  Weight: {car.Weight}" + Environment.NewLine +
                                  $"  Color: {car.Color}");                
            }
        }
    }
}
