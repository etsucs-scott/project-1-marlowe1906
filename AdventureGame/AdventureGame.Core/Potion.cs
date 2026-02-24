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
            Console.WriteLine("You found a potion! +10 Health!");
            Console.WriteLine();

            // Directly modifies the passed Player object (same reference)
            p.Health += 10;
        }
    }
}
