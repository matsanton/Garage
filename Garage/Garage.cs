using GarageApp.Vehicles;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GarageApp
{
    public class Garage<T> : IEnumerable<T> where T : Vehicle
    {
        #region Private fields
        private readonly T[] vehicles;
        private int count = 0;
        #endregion

        #region Properties
        public int Capacity { get; }
        public bool IsFreeSpace { get; private set; } = true;
        public int Count => count;
        #endregion

        #region Constructor
        public Garage(int capacity)
        {
            if (capacity <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            Capacity = capacity;
            vehicles = new T[capacity];
        }
        #endregion

        #region Public Methods
        public bool Park(T vehicle)
        {
            if (IsFreeSpace)
            {
                if (GetFirstFreeSpot(out int index))
                {
                    count++;
                    vehicles[index] = vehicle;
                    if (count == Capacity) IsFreeSpace = false;
                    return true;
                }
            }
            return false;
        }

        private bool GetFirstFreeSpot(out int index)
        {
            index = 0;
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] == null)
                {
                    index = i;
                    return true;
                }
            }
            return false;
        }

        public bool Leave(T curentVehicle)
        {
            if (curentVehicle == null) return false;
            int index = Array.IndexOf(vehicles, curentVehicle);

            if (index >= 0)
            {
                // The vehicle is in the garage
                vehicles[index] = null;
                count--;
                IsFreeSpace = true;
                return true;
            }
            else
            {
                return false;
            }

        }
        #endregion
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in vehicles)
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
