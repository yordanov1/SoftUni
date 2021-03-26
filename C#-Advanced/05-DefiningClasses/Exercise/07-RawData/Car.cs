using System;
using System.Collections.Generic;
using System.Text;

namespace Exer_07.RawData
{
    public class Car
    {        
        public Car(Model model, Cargo cargo , Engine engine, Tire tire)
        {
            Model = model;
            Cargo = cargo;
            Engine = engine;
            Tire = tire;
        }

        public Model Model { get; set; }
        public Cargo Cargo { get; set; }    //!!!
        public Engine Engine { get; set; }
        public Tire Tire { get; set; }
    }
}
