using System;

namespace lightning {
    public class Car {
        private string _baseSound = "Boink";
        public string Make {get; set;}
        public string Model {get; set;}
        public int Year {get; set;}
        public double Price {get; set;}

    // Overloading Drive with different arities
        public void Drive() {
            Console.WriteLine(_baseSound);
            }
        public void Drive(string soundToMake) {
            Console.WriteLine(soundToMake);
        }
    }
}