using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building FiveOneTwoEigth = new Building("512 8th Avenue", "Steve Brownlee"){
                Width = 500.83,
                Depth = 500.1,
                Stories = 3,
            };

            Building SamsHouse = new Building("302 Vivelle Avenue", "Some guy in the 50s"){
                Width = 500.2,
                Depth = 200.5,
                Stories = 2,
            };

            Building NSS = new Building("500 Interstate Boulevard South", "John Wark"){
                Width = 398.1,
                Depth = 345.67,
                Stories = 5,
            };

            FiveOneTwoEigth.Construct();
            SamsHouse.Construct();
            NSS.Construct();

            FiveOneTwoEigth.Purchase("Bob");
            SamsHouse.Purchase("Sam");
            NSS.Purchase("Niall");

            // FiveOneTwoEigth.PrintPrivateInformation();
            // SamsHouse.PrintPrivateInformation();
            // NSS.PrintPrivateInformation();

            City Nashville = new City("Carl Dean");

            Nashville.Found();

            Nashville.AddBuilding(FiveOneTwoEigth);
            Nashville.AddBuilding(SamsHouse);
            Nashville.AddBuilding(NSS);

            foreach (Building building in Nashville.Buildings)
            {
                building.PrintPrivateInformation();
            }


        }
    }
}

// 100 Main Street
// ---------------
// Designed by Steve Brownlee
// Constructed on 2/1/18 7:19:08 AM
// Owned by Bob Ross
// 16128 cubic meters of space
