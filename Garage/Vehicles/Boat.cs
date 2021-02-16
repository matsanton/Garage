using System;
using System.Collections.Generic;
using System.Text;

namespace GarageApp.Vehicles
{
    class Boat : Vehicle
    {
        public int NumberOfEngines { get; set; }

        public Boat(string regno, double weight, int numberOfEngines) : base(regno, weight)
        {
            NumberOfEngines = numberOfEngines;
        }
    }
}
