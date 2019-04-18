using System;

namespace MonsterHunter
{
    public class Wight : ISpirit
    {
        public void Douse(string attack)
        {
            if (attack == "Holy Water")
            {
                Console.WriteLine("You just killed the Wight");
            }
        }
    }
}