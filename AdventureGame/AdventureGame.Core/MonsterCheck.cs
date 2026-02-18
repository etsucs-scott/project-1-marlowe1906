using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame.Core
{
    // Responsible for checking if any monsters exist on the map
    internal class MonsterCheck
    {
        // Scans the map string for the 'M' character
        // Returns true if at least one monster is found
        public bool checkForMonsters(string mapData)
        {
            for (int i = 0; i < mapData.Length; i++)
            {
                // If a monster tile is detected
                if (mapData[i] == 'M')
                {
                    return true;
                }
            }

            // No monsters were found in the map
            return false;
        }
    }
}
