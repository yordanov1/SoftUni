using System;
using System.Collections.Generic;
using System.Text;

namespace Exer_07.RawData
{
    public class Cargo
    {
        public Cargo(string cargoType)
        {
            CargoType = cargoType;
        }
        public string CargoType { get; set; }
    }
}
