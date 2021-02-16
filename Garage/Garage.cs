using GarageApp.Vehicles;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GarageApp
{
    public class Garage<T> : IEnumerable<T> where T : Vehicle
    {
        private readonly T[] vehicles;
        private int count = 0;

        public int Capacity { get; }
        public bool SpaceAvailable { get; private set; } = true;
        public int Count => count;

        public Garage(int capacity)
        {
            if (capacity <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            Capacity = capacity;
            vehicles = new T[capacity];
        }

        internal bool Park(T vehicle)
        {
            if (SpaceAvailable)
            {
                vehicles[count++] = vehicle;
                if (count == Capacity)
                {
                    SpaceAvailable = false;
                }
                return true;
            }
            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach(var item in vehicles)
            {
                yield return item as T;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
       
    }
}
