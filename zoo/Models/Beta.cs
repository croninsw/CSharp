using System;

namespace ZooZaniness
{
    public class Beta : ISwim
    {
        public string Size { get; set; }
        public int MaxDepth { get; set; }

        public void Swim() {
            Console.WriteLine($"The Beta Fish is swimming.");
        }

    }
}