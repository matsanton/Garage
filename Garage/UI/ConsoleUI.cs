using System;
using System.Collections.Generic;
using System.Text;

namespace GarageApp.UI
{
    class ConsoleUI
    {
        public void ViewMenu()
        {
            Console.Clear();
            Console.WriteLine("-Garage-");
            Console.WriteLine("1. Skapa Garage");
            Console.WriteLine("2. Lista alla fordon");
            Console.WriteLine("3. ");
            Console.WriteLine("4. ");
            Console.WriteLine("5. ");
            Console.WriteLine("0. Exit");

        }
        public int GetInput()
        {
            char key = Console.ReadKey(intercept: true).KeyChar;
            switch (key)
            {
                case '1': return 1;
                case '2': return 2;
                default: return -1;
            }
        }
    }

}
