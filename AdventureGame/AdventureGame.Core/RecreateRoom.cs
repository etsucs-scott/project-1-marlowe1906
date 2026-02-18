using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame.Core
{
    // Responsible for rendering the map visually in the console
    public class RecreateRoom
    {
        // Prints the map with a border and returns the original map string
        public string Generate(string mapData, int height, int width)
        {
            // Convert the map string into a character array for indexed access
            char[] splitData = mapData.ToCharArray();
            int placeHolder = 0;

            // Draw top border
            for (int i = 0; i <= width + 1; i++)
            {
                Console.Write("#");
            }
            Console.WriteLine();

            // Draw each row of the room
            for (int i = 0; i < height; i++)
            {
                Console.Write("#"); // Left border

                for (int j = 0; j < width; j++)
                {
                    // Print each tile from the 1D map representation
                    Console.Write(splitData[placeHolder]);
                    placeHolder++;
                }

                Console.Write("#"); // Right border
                Console.WriteLine();
            }

            // Draw bottom border
            for (int i = 0; i <= width + 1; i++)
            {
                Console.Write("#");
            }
            Console.WriteLine();

            return mapData;
        }
    }
}
