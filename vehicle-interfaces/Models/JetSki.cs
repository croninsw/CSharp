using System;

namespace Garage
{
    public class JetSki : IWaterVehicle
    {
        public int Wheels { get; set; }
        public int Doors { get; set; }
        public int PassengerCapacity { get; set; }
        public bool Winged { get; set; }
        public string TransmissionType { get; set; }
        public double EngineVolume { get; set; }
        public double MaxWaterSpeed { get; set; }
        public double MaxLandSpeed { get; set; }
        public double MaxAirSpeed { get; set; }
        public void Start() {
            Console.WriteLine($"The JetSki has been started.");
        }
        public void Stop() {
            Console.WriteLine($"The JetSki has stopped.");
        }
        public void Drive() {
            Console.WriteLine($"The JetSki is now moving forward!");
        }
    }

}