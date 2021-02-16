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
            IConsoleUI ui = new ConsoleUI();
            GarageHandler gh = new GarageHandler(ui);
            gh.Run();
        }
    }
}
