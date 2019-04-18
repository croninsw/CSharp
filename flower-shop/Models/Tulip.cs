using System;

namespace FlowerShop
{
    public class Tulip : IMothersDay
    {
        public string Color { get; set; }

        public string Type { get; set; }

        public int NumberofPetals { get; set; }

        public int Lenght { get; set; }

        public override string ToString(){
            return "A colorful tulip";
        }
    }
}