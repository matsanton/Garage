using GarageApp.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace GarageApp
{
    class GarageApplication
    {
        public void Run()
        {
            ConsoleUI ui = new ConsoleUI();
            GarageHandler gh = new GarageHandler(ui);
        }
    }
}
