namespace GarageApp.Vehicles
{
    internal class Airplane : Vehicle
    {
        public double Payload { get; set; }

        public Airplane(string regno, double weight, double payload) : base(regno, weight)
        {
            Payload = payload;
        }

        public override string ToString()
        {
            return $"{GetType().Name}: {base.ToString()} Lastvikt{Payload}";
        }

    }
}
