using System;
using System.Collections.Generic;

namespace ZooZaniness
{
    class Program
    {
        static void Main(string[] args)
        {
            // create instances of lists to store animals by type
            List<IDig> DiggingAnimals = new List<IDig>();
            List<ISwim> SwimmingAnimals = new List<ISwim>();
            List<IFly> FlyingAnimals = new List<IFly>();
            List<IWalk> WalkingAnimals = new List<IWalk>();

            // create instances of animals
            Parakeet Parakeet = new Parakeet();
            Earthworm Jim = new Earthworm();
            Terrapin Beer = new Terrapin();
            Timber ScarySnek = new Timber();
            Mouse Jerry = new Mouse();
            Ant Aunt = new Ant();
            Finch Fry = new Finch();
            Beta Dude = new Beta();
            Copperhead OtherScarySnek = new Copperhead();
            Gerbil Gerry = new Gerbil();

            // add animals to correspoding container list elements
            DiggingAnimals.Add(Jim);
            DiggingAnimals.Add(Gerry);
            DiggingAnimals.Add(Aunt);
            DiggingAnimals.Add(OtherScarySnek);
            Console.WriteLine($@"
                DIGGING ANIMALS
                ===============
            ");
            foreach(IDig Animal in DiggingAnimals)
            {
                Console.WriteLine($"{Animal}");
            }

            SwimmingAnimals.Add(Beer);
            SwimmingAnimals.Add(Dude);
            SwimmingAnimals.Add(OtherScarySnek);

            FlyingAnimals.Add(Parakeet);
            FlyingAnimals.Add(Fry);

            WalkingAnimals.Add(Beer);
            WalkingAnimals.Add(ScarySnek);
            WalkingAnimals.Add(Jerry);
        }
    }
}
