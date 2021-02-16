using System;
using System.Collections.Generic;
using System.Text;

namespace GarageApp.Vehicles
{
    class Car : Vehicle
    {
        public string FuelType { get; set; }

        public Car(string regno, double weight, string fuelType) : base(regno, weight)
        {
            FuelType = fuelType;
        }
    }
}
