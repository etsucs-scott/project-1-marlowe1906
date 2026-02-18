using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame.Core
{
    // Determines what type of tile should be placed in the room
    internal class RoomPlacement
    {
        Random random = new Random();

        // Randomly selects a tile type based on a number range
        // Lower numbers represent special tiles; all others default to empty space
        public string Type()
        {
            // Generates a number between 0 and 15
            int type = random.Next(0, 16);

            // Specific numbers map to special tiles
            switch (type)
            {
                case 0:
                    return "M"; // Monster
                case 1:
                    return "S"; // Sword / weapon upgrade
                case 2:
                    return "#"; // Wall
                case 3:
                    return "I"; // Potion / item
            }

            // All other values return an empty floor tile
            return ".";
        }
    }
}
