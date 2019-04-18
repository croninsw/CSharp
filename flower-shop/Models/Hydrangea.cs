using System;

namespace FlowerShop
{
    public class Hydrangea : IMothersDay
    {
        public string Color { get; set; }

        public string Type { get; set; }

        public int NumberofPetals { get; set; }

        public int Length { get; set; }

        public override string ToString()
        {
            return "A splendid Hydrangea";
        }
    }
}