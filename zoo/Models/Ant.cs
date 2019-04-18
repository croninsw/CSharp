using System;

namespace ZooZaniness
{
    public class Ant : IDig
    {
        public string DigTool { get; set; }
        public string Size { get; set; }
        public void Dig() {
            Console.WriteLine($"The ant is digging.");
        }
        public void Walk() {
            Console.WriteLine($"The ant is walking.");
        }
    }
}