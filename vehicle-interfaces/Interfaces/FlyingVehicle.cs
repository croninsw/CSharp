using System;

namespace Garage
{
    public interface IFlyingVehicle
    {
        int Wheels { get; set; }
        int Doors { get; set; }
        int PassengerCapacity { get; set; }
        bool Winged { get; set; }
        string TransmissionType { get; set; }
        double EngineVolume { get; set; }
        double MaxAirSpeed { get; set; }
        void Start();
        void Stop();
        void Drive();
        void Fly();
    }
}