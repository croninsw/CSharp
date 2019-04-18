using System;

namespace ZooZaniness
{
    public class Parakeet : IFly
    {
        public int MaxHeight { get; set; }
        public string Size { get; set; }
        public void Fly() {
            Console.WriteLine($"The parakeet is flying.");
        }
    }
}