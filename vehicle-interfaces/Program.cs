using System;
using System.Linq;
using System.Collections.Generic;

namespace Garage
{
    public class Program
    {

        public static void Main()
        {
            Cessna M1 = new Cessna();
            Cessna M2 = new Cessna();
            Motorcycle Harley = new Motorcycle();
            JetSki JetSki = new JetSki();

            // Build a collection of all vehicles that fly
            List<IFlyingVehicle> Flying = new List<IFlyingVehicle>();

            Flying.Add(M1);
            Flying.Add(M2);
            // With a single `foreach`, have each vehicle Fly()
            foreach (IFlyingVehicle plane in Flying)
            {
                plane.Fly();
            }
            // Build a collection of all vehicles that operate on roads
            List<ILandVehichle> Driving = new List<ILandVehichle>();

            Driving.Add(Harley);
            // With a single `foreach`, have each road vehicle Drive()
            foreach (ILandVehichle car in Driving)
            {
                car.Drive();
            }


            // Build a collection of all vehicles that operate on water
            List<IWaterVehicle> Boating = new List<IWaterVehicle>();

            Boating.Add(JetSki);
            // With a single `foreach`, have each water vehicle Drive()
            foreach (IWaterVehicle boat in Boating)
            {
                boat.Drive();
            }
        }

    }
}