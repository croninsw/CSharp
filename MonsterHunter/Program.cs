using System;

namespace MonsterHunter
{
    class Program
    {
        public static void Main()
        {
            Hunter VonRimmersmark = new Hunter("Erich", "Von Rimmersmark");

            Demon Satan = new Demon();
            Ghast MC = new Ghast();
            Ghoul YoMomma = new Ghoul();
            Mummy Tuts = new Mummy();
            Vampire Dracula = new Vampire();
            Wight Walker = new Wight();
            Zombie Steve = new Zombie();


            VonRimmersmark.Ignite(Satan);
            VonRimmersmark.SplashWater(Satan);
            VonRimmersmark.WieldSilver(Satan);
            VonRimmersmark.Ignite(Tuts);
            VonRimmersmark.Ignite(Steve);
            VonRimmersmark.SplashWater(YoMomma);
            VonRimmersmark.SplashWater(MC);
            VonRimmersmark.WieldSilver(Dracula);
            VonRimmersmark.Ignite(Tuts);

            Console.WriteLine(VonRimmersmark);
        }
    }
}


