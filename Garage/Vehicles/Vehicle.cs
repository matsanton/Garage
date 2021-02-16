using System;
using System.Collections.Generic;
using System.Text;

namespace GarageApp.Vehicles
{


    public abstract class Vehicle : IVehicle
    {
        private string regno;

        public string RegNumber
        {
            get { return regno; }
            set { regno = value.ToUpper(); }
        }

        public double Weight { get; set; }


        public Vehicle(string regno, double weight)
        {
            RegNumber = regno;
            Weight = weight;
        }

        public override string ToString()
        {
            return $"Regnr: {RegNumber} : Fordonsvikt: {Weight}";
        }

    }
}
