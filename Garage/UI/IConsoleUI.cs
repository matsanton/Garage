namespace GarageApp.UI
{
    interface IConsoleUI
    {
        int GetInput();
        void ViewMenu();

        void Write(string line);
    }
}