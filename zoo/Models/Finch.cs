using System;

namespace ZooZaniness
{
    public class Finch : IFly
    {
        public string Size { get; set; }
        public int MaxHeight { get; set; }

        public void Fly() {
            Console.WriteLine($"The finch is flying.");
        }

    }
}