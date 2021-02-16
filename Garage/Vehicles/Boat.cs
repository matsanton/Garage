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
        public override string ToString()
        {
            return $"{GetType().Name}: {base.ToString()} Antal motorer: {NumberOfEngines}";
        }
    }
}
