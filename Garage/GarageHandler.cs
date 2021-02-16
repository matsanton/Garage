using GarageApp.UI;
using GarageApp.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;

namespace GarageApp
{
    class GarageHandler
    {
        const int MaxCapacity = 16;
        private Garage<Vehicle> garage = new Garage<Vehicle>(MaxCapacity);

        public GarageHandler(ConsoleUI ui)
        {
            Init();
        }

        private void Init()
        {
            garage.Park(new Car("car123", weight: 999.0, "Diesel"));
            garage.Park(new Bus("bus1321", weight: 3000.0, numberOfSeats: 30));
            garage.Park(new Truck("abc000", weight: 3500.0, load: 2000.0));
        }

        internal void Run(ConsoleUI ui)
        {
            while(true)
            {
                ui.ViewMenu();
                int choice = ui.GetInput();

                switch(choice)
                {
                    case 1: ListAllVehicles();
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case -1: continue;
                    

                }
            }
        }

        private void ListAllVehicles()
        {
            foreach (var item in garage)
            {
                Console.WriteLine(item.ToString());
            }
        }
        //Car myCar = new Car();
        //    if internal void Run()
        //{
        //    throw new NotImplementedException();
        //}

        //(myGarage.Park(myCar))
        //    {
        //        Console.WriteLine("Success parking");
        //    }
    }
}
