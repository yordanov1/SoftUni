using System;
using System.Collections.Generic;
using System.Text;

namespace Exer_07.RawData
{
    public class Tire
    {
        public Tire(double tire1Pressure, double tire2Pressure, double tire3Pressure, double tire4Pressure)
        {
            Tire1Pressure = tire1Pressure;
            Tire2Pressure = tire2Pressure;
            Tire3Pressure = tire3Pressure;
            Tire4Pressure = tire4Pressure;
        }

        public double Tire1Pressure { get; set; }
        public double Tire2Pressure { get; set; }
        public double Tire3Pressure { get; set; }
        public double Tire4Pressure { get; set; }
    }
}
