using System;
using System.Collections.Generic;

namespace sets
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> Showroom = new HashSet<string>();
            {
                Showroom.Add("240");
                Showroom.Add("Exterra");
                Showroom.Add("Supra");
                Showroom.Add("BMW");
            }

            // Console.WriteLine(Showroom.Count);

            Showroom.Add("240");

            // Console.WriteLine(Showroom.Count);

            HashSet<string> UsedCars = new HashSet<string>();
            {
                UsedCars.Add("Camry");
                UsedCars.Add("Accord");
            }

            Showroom.UnionWith(UsedCars);
            // foreach(var car in Showroom)
            // {
            //     Console.WriteLine($"{car}");
            // }
            // if(Showroom.Contains("Camry"))
            // {
            //     Showroom.Remove("Camry");
            // }
            // foreach(var car in Showroom)
            // {
            //     Console.WriteLine($"{car}");
            // }

            HashSet<string> Junkyard = new HashSet<string>();
            {
                Junkyard.Add("240");
                Junkyard.Add("240");
                Junkyard.Add("Camry");
                Junkyard.Add("Wrangler");
                Junkyard.Add("Camaro");
                Junkyard.Add("66D");
            };

            HashSet<string> clone = new HashSet<string>(Showroom);

            clone.IntersectWith(Junkyard);

            Showroom.UnionWith(Junkyard);
        }
    }
}

