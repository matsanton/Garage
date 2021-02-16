namespace GarageApp.Vehicles
{
    internal class Airplane : Vehicle
    {
        public double CargoWeight { get; set; }

        public Airplane(string regno, double weight, double cargoWeight) : base(regno, weight)
        {
            CargoWeight = cargoWeight;
        }

    }
}
