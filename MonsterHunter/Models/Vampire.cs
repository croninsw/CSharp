using System;

namespace MonsterHunter
{
    public class Vampire : IUndead
    {
        public void Stab(string attack)
        {
            if (attack == "Silver")
            {
                Console.WriteLine("You just killed the Vampire");
            }
        }
    }
}