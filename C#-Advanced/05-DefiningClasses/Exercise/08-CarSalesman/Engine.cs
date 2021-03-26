using System;
using System.Collections.Generic;
using System.Text;

namespace Exer_08.CarSalesman
{
    public class Engine
    {       
        public Engine(string model, string power, string displacemen, string efficiency)
        {
            Model = model;
            Power = power;
            Displacement = displacemen;
            Efficiency = efficiency;
        }

        public string Model { get; set; }
        public string Power { get; set; }
        public string Displacement { get; set; }
        public string Efficiency { get; set; }

        public override string ToString()
        {
            return $"  {Model}:" + Environment.NewLine +
                   $"    Power: {Power}" + Environment.NewLine +
                   $"    Displacement: {Displacement}" + Environment.NewLine +
                   $"    Efficiency: {Efficiency}";                           
        }
    }
}
