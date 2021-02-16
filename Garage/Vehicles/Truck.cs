using System;
using System.Collections.Generic;
using System.Text;

namespace GarageApp.Vehicles
{
     
    public class Truck : Vehicle
    {
        public double Load { get; set; }
        public Truck(string regno, double weight, double load) : base(regno, weight)
        {
            Load = load;
        }
    }
}
