using System;
using System.Collections.Generic;
using System.Text;

namespace Garage.Vehicles
{
   

    abstract class Vehicle
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
