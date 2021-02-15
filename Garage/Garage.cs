using Garage.Vehicles;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Garage
{
    class Garage<T> : IEnumerable<T> where T : Vehicle 
    {
        private Vehicle[] vehicles;

        public Garage(int capacity)
        {
            vehicles = new Vehicle[capacity];
        }

        internal bool Park(T parkingVehicle)
        {
            return true;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var vehicle in vehicles)
            {
                if (vehicle != null)
                    yield return vehicle as T;
            }
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
