using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame.Core
{
    internal class WeaponChance
    {
        public void choose(string mapData, int currentLocation, int newLocation,  char[]splitMap, Player p)
        {
            Weapon weapon = new Weapon();
            Random random = new Random();

            if (mapData[newLocation] == 'I')
            {
                int choice = random.Next(0,21);
                if (choice >= 0 && choice < 10)
                {
                    weapon.ironSword(p);
                }
                else if (choice >= 10 && choice < 18)
                {
                    weapon.goldSword(p);
                }
                else if (choice >= 18 && choice <= 20)
                {
                    weapon.diamondSword(p);
                }
            }

        }
    }
}
