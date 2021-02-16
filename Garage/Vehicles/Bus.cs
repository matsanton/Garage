using System;
using System.Collections.Generic;
using System.Text;

namespace GarageApp.Vehicles
{
    class Bus : Vehicle
    {
        public int NumberOfSeats { get; set; }

        public Bus(string regno, double weight, int numberOfSeats) : base(regno, weight)
        {
            NumberOfSeats = numberOfSeats;
        }

        public override string ToString()
        {
            return $"{GetType().Name}: {base.ToString()} Antal platser: {NumberOfSeats}";
        }
    }
}
