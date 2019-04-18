using System;
using System.Collections.Generic;

namespace lightning
{

    class Program
    {
        static void Main(string[] args)
        {
            Car TwoForty = new Car() {
                Make = "Volvo",
                Model = "240",
                Year = 1992,
                Price = 2000.00
            };

            Car GMC = new Car() {
                Make = "GM",
                Model = "FightLine",
                Year = 2020,
                Price = 20400.87
            };

            Car Xterra = new Car() {
                Make = "Nissan",
                Model = "Xterra",
                Year = 2007,
                Price = 11765.45
            };


            List<Car> CarLot = new List<Car>(){
                Xterra,
                TwoForty,
                GMC
            };


                foreach(Car car in CarLot)
                {
                    Console.WriteLine($@"
                        Make: {car.Make}
                        Model: {car.Model}
                        Year: {car.Year}
                        Price: {car.Price}
                    ");
                }
        }
    }
}

// Define a Dictionary to represent a car. Each dictionary should have the following KeyValuePairs.

// * Make
// * Model
// * Year
// * Price

// Create three car dictionaries for three different car models
