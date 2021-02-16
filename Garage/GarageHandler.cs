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
        private readonly IConsoleUI UI;

        public GarageHandler(IConsoleUI ui)
        {
            UI = ui;
        }

        private void Seed()
        {
            garage.Park(new Car("car123", weight: 999.0, "Diesel"));
            garage.Park(new Bus("bus321", weight: 3000.0, numberOfSeats: 30));
            garage.Park(new Truck("abc000", weight: 3500.0, load: 2000.0));
            UI.Write($"Garaget populerat med {garage.Count} fordon.");
            UI.Write("Press any key to return to main menu");
            Console.ReadKey();
        }

        internal void Run()
        {
            while (true)
            {
                UI.ViewMenu();
                int choice = UI.GetInput();
                switch (choice)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        ListAllVehicles();
                        break;
                    case 2:
                        break;
                    case 3:
                        Seed();
                        break;
                    case -1: continue;

                }
            }
        }

        private void ListAllVehicles()
        {
            if (garage.Count == 0)
            {
                UI.Write("Garaget är tomt.");
            }
            else
            {
                UI.Write($"Antal i garaget: {garage.Count}");
                UI.Write("Fordon i garaget just nu:");
                int plats = -1;
                foreach (var v in garage)
                {
                    plats++;
                    if (v is null)
                    {
                        continue;
                    }
                    else
                    {
                        UI.Write($"Plats {plats}: {v.ToString()}");
                    }
                }
            }
            UI.Write("Press any key to return to main menu");
            Console.ReadKey();
        }

    }
}
