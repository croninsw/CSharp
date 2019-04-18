using System;

namespace ZooZaniness
{
    public class Gerbil : IDig
    {
        public string DigTool { get; set; }
        public string Size { get; set; }
        public void Dig() {
            Console.WriteLine($"The gerbil is burrowing.");
        }
        public void Walk() {
            Console.WriteLine($"The gerbil is walking.");
        }
    }
}