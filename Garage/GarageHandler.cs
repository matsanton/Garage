using Garage.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Garage
{
    class GarageHandler
    {
        internal void Run()
        {

            Garage<Vehicle> myGarage = new Garage<Vehicle>(16);

            Car myCar = new Car();
            if (myGarage.Park(myCar))
            {
                Console.WriteLine("Success parking");
            }

        }
    }
}
