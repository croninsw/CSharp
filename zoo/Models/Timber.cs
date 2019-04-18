using System;

namespace ZooZaniness
{
    public class Timber : IWalk
    {
        public string Size { get; set; }
        public void Walk() {
            Console.WriteLine($"The Timber snake is slithering.");
        }
        public void Run() {
            Console.WriteLine($"The Timber snake is running?");
        }
    }
}