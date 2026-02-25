using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame.Core
{
    // Represents a health potion that restores player health
    internal class Potion
    {
        // Increases the player's health when the potion is collected
        public void retrieve(Player p)
        {

            // Directly modifies the passed Player object (same reference)
            if (p.Health <= 130 && p.Health > 0)
            {
                Console.Write("You found a potion! +20 Health!");
                p.Health += 20;
            }
            else if (p.Health <= 149 && p.Health >130)
            {
                Console.Write("You've reached max health!");
                p.Health = 150;
            }
            else
            {
                Console.Write("You're already at max health!");
            }
        }
    }
}
