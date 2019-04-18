using System;

namespace ZooZaniness
{
    public class Copperhead : IDig, ISwim
    {
        public string DigTool { get; set; }
        public string Size { get; set; }
        public int MaxDepth { get; set; }
        public void Dig() {
            Console.WriteLine($"The Copperhead snake is burrowing.");
        }
        public void Walk() {
            Console.WriteLine($"The Copperhead snake is slithering.");
        }
        public void Swim() {
            Console.WriteLine($"The Copperhead snake is gliding across the water.");
        }
    }
}