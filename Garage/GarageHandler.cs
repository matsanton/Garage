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
        private IConsoleUI UI;

        public GarageHandler(IConsoleUI ui)
        {
            UI = ui;
            Init();
            Run();
        }

        private void Init()
        {
            garage.Park(new Car("car123", weight: 999.0, "Diesel"));
            garage.Park(new Bus("bus1321", weight: 3000.0, numberOfSeats: 30));
            garage.Park(new Truck("abc000", weight: 3500.0, load: 2000.0));
        }

        internal void Run()
        {
            while(true)
            {
                UI.ViewMenu();
                int choice = UI.GetInput();

                switch(choice)
                {
                    case 0: Environment.Exit(0);
                        break;
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
            UI.Write("Fordon i garaget just nu:");
            int plats = 0;
            foreach (var item in garage)
            {
                Console.WriteLine($"Plats {plats}: ");
                UI.Write(item.ToString());
            }

        }

    }
}
