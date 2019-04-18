using System;

namespace FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            FlowerShop BriansBulbs = new FlowerShop();

            BriansBulbs.MakeMothersDayArrangement()
            .ForEach(flower => Console.WriteLine(flower));
        }
    }
}
