using System.Data;
using System.Diagnostics;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

namespace AdventureGame.Core
{
    // Responsible for generating the initial room layout and returning the map as a string
    public class RoomGeneration
    {
        Random random = new Random();

        string mapData = "";
        int exitTileX;
        int exitTileY;

        // Generates a room with borders, player start, exit, and random tile placement
        public string Generate(int height, int width)
        {
            string mapData = "";

            // Randomly determine exit tile coordinates
            exitTileX = random.Next(0, height);
            exitTileY = random.Next(0, width);

            // Draw top border
            for (int i = 0; i <= width + 1; i++)
            {
                Console.Write("#");
            }
            Console.WriteLine();

            // Generate interior tiles row by row
            for (int i = 0; i < height; i++)
            {
                Console.Write("#"); // Left border

                for (int j = 0; j < width; j++)
                {
                    // Randomly choose what type of tile to place
                    RoomPlacement placement = new RoomPlacement();
                    string choice = placement.Type();

                    // Bottom-left corner is forced as player start position
                    if (i == height - 1 && j == 0)
                    {
                        Console.Write("P");
                        mapData += "P";
                    }
                    // Place exit at randomly selected coordinates
                    else if (i == exitTileY && j == exitTileX)
                    {
                        Console.Write("E");
                        mapData += "E";
                    }
                    // Otherwise place randomly selected tile
                    else if (choice == ".")
                    {
                        Console.Write(choice);
                        mapData += ".";
                    }
                    else if (choice == "M")
                    {
                        Console.Write(choice);
                        mapData += "M";
                    }
                    else if (choice == "#")
                    {
                        Console.Write(choice);
                        mapData += "#";
                    }
                    else if (choice == "I")
                    {
                        Console.Write("I");
                        mapData += "I";
                    }
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

            // Return the 1D string representation of the map
            return mapData;
        }
    }
}
