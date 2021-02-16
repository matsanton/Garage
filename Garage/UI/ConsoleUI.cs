using System;
using System.Collections.Generic;
using System.Text;

namespace GarageApp.UI
{
    class ConsoleUI : IConsoleUI
    {
        public void ViewMenu()
        {
            Console.Clear();
            Console.WriteLine("---Garage---");
            Console.WriteLine("1. Lista alla fordon");
            Console.WriteLine("2. ");
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
                case '0': return 0;
                case '1': return 1;
                case '2': return 2;
                default:
                    Console.WriteLine("Skriv in en siffra från menyn.");
                    return -1;
            }
        }

        public void Write(string line)
        {
            Console.WriteLine(line);
        }
    }

}
