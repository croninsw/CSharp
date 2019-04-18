using System;

namespace Garage
{
    public interface IWaterVehicle
    {
        int PassengerCapacity { get; set; }
        string TransmissionType { get; set; }
        double EngineVolume { get; set; }
        double MaxWaterSpeed { get; set; }
        void Start();
        void Stop();
        void Drive();
    }
}