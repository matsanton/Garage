using System;
using System.Collections.Generic;
using System.Text;

namespace GarageApp.Vehicles
{
    class Motorcycle : Vehicle
    {
        public int EngineSize { get; set; }

        public Motorcycle(string regno, double weight, int engineSize) : base(regno, weight)
        {
            EngineSize = engineSize;
        }
    }
}
