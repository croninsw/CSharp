using System;

namespace MonsterHunter
{
    public class Ghoul : IUndead, ISpirit
    {
        public void Douse(string attack)
        {
            if (attack == "Holy Water")
            {
                Console.WriteLine("You just killed the Ghoul");
            }
        }
        public void Stab(string attack)
        {
            if (attack == "Silver")
            {
                Console.WriteLine("You just killed the Ghoul");
            }
        }
    }
}