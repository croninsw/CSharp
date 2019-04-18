using System;

namespace ZooZaniness
{
    public class Earthworm : IDig
    {
        public string DigTool { get; set; }
        public string Size { get; set; }
        public void Dig() {
            Console.WriteLine($"The earthworm is digging.");
        }
        public void Walk() {
            Console.WriteLine($"The earthworm is slithering.");
        }
    }
}