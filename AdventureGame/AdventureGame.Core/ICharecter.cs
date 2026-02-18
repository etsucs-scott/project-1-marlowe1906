using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame.Core
{
    // Defines a contract for any character in the game (Player, Monster, etc.)
    // Any class implementing this must include these properties and behaviors
    public interface ICharecter
    {
        // Basic identity and combat stats shared by all characters
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }

        // Forces implementing classes to define how they attack another character
        public void attack(ICharecter target);

        // Forces implementing classes to define how they receive damage
        public void takeDamage(int amount);
    }
}
