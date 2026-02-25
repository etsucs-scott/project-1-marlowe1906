using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame.Core
{
    internal class Weapon
    {
        public void ironSword(Player p)
        {
            Console.Write("You found an Iron Sword! Use this sword to deal 20 damage to monsters!");
            if (p.AttackPower < 20)
            {
                p.AttackPower = 20;
            }
            p.inventory.Add("Iron Sword (20 DMG)");
        }
        public void goldSword(Player p)
        {
            Console.Write("You found a Gold Sword! Use this sword to deal 30 damage to monsters!");
            p.AttackPower = 30;
            if (p.AttackPower < 30)
            {
                p.AttackPower = 30;
            }
            p.inventory.Add("Gold Sword (30 DMG)");
        }
        public void diamondSword(Player p)
        {
            Console.Write("You found a Diamond Sword! Use this sword to deal 40 damage to monsters!");
            if (p.AttackPower < 40)
            {
                p.AttackPower = 40;
            }
            p.inventory.Add("Diamond Sword (40 DMG)");
        }
    }
}
