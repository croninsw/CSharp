using System;

namespace MonsterHunter
{
    public class Ghast : ICombustable, ISpirit
    {
        public void Burn(string attack)
        {
            if (attack == "Fire")
            {
                Console.WriteLine("You just killed the Ghast");
            }
        }
        public void Douse(string attack)
        {
            if (attack == "Holy Water")
            {
                Console.WriteLine("You just killed the Ghast");
            }
        }
    }
}