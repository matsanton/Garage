using GarageApp.Vehicles;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GarageApp
{
    public class Garage<T> : IEnumerable<T> where T : Vehicle
    {
        private T[] vehicles;
        private int nextFreeSpot = 0;

        public int Capacity { get; }
        public bool SpaceAvailable { get; private set; }


        public Garage(int capacity)
        {
            if (capacity <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            Capacity = capacity;
            vehicles = new T[capacity];
        }

        internal bool Park(T parkingVehicle)
        {
            if (SpaceAvailable)
            {
                vehicles[nextFreeSpot++] = parkingVehicle;
                if (nextFreeSpot == Capacity)
                {
                    SpaceAvailable = false;
                }
                return true;
            }
            return false;
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
