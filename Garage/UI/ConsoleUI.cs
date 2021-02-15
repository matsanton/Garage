using System;
using System.Collections.Generic;
using System.Text;

namespace Garage.UI
{
    class ConsoleUI
    {
        public ConsoleKey GetKey()
        {
            return Console.ReadKey(intercept: true).Key;
        }
    }
}
