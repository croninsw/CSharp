using System;

namespace ZooZaniness
{
    public class Terrapin : IWalk, ISwim
    {
        public string Size { get; set; }
        public int MaxDepth { get; set; }
        public void Walk() {
            Console.WriteLine($"The Terrapin is walking.");
        }
        public void Run() {
            Console.WriteLine($"The Terrapin is running.");
        }
        public void Swim() {
            Console.WriteLine($"The Terrapin is swimming");
        }
    }
}