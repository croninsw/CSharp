using System;

namespace ZooZaniness
{
    public class Mouse : IWalk
    {
        public string Size { get; set; }

        public void Walk() {
            Console.WriteLine($"The Terrapin is walking.");
        }
        public void Run() {
            Console.WriteLine($"The Terrapin is running.");
        }

    }
}