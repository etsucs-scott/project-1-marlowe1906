using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame.Core
{
    // Responsible for finding the player's position in the map string
    internal class LocatePlayer
    {
        // Searches through the map data and returns the index of 'P'
        // Returns -1 if the player is not found
        public int getLocation(string mapData)
        {
            // Loop through every character in the map string
            for (int i = 0; i < mapData.Length; i++)
            {
                // Check if current position contains the player symbol
                if (mapData[i] == 'P')
                {
                    return i; // Return the index where the player is located
                }
            }

            // If no 'P' is found in the map
            return -1;
        }
    }
}
