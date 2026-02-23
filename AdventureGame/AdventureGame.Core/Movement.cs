using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame.Core
{
    // Handles player movement and updates the map accordingly
    public class Movement
    {
        // Processes movement input and returns the updated map string
        public string move(string mapData, int height, int width, Player p)
        {
            RecreateRoom room = new RecreateRoom();
            LocatePlayer locate = new LocatePlayer();
            Relocate relocate = new Relocate();

            // Find the player's current index in the map
            int currentLocation = locate.getLocation(mapData);
            int newLocation = currentLocation;

            // Convert map string into a mutable character array
            char[] splitMap = mapData.ToCharArray();
            string newData = "";

            // If player is not found, the game is considered completed
            if (currentLocation == -1)
            {
                return "Completed";
            }
            // Read movement input without displaying the pressed key
            ConsoleKeyInfo key = Console.ReadKey(true);
            Console.Clear();

            // Calculate new position based on WASD input
            if (key.Key == ConsoleKey.W || key.Key == ConsoleKey.UpArrow)
            {
                newLocation = currentLocation - width; // Move up
                relocate.relocate(mapData, currentLocation, newLocation, splitMap, p);
            }
            else if (key.Key == ConsoleKey.E)
            {
                Console.WriteLine("Inventory: ");
                foreach (string item in p.inventory)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine();
            }
            else if (key.Key == ConsoleKey.Q)
            {
                Console.WriteLine("Stats:");
                Console.WriteLine($"Attack power: {p.AttackPower}");
                Console.WriteLine($"Health: {p.Health}");
                Console.WriteLine();
            }


            else if (key.Key == ConsoleKey.S || key.Key == ConsoleKey.DownArrow)
            {
                newLocation = currentLocation + width; // Move down
                relocate.relocate(mapData, currentLocation, newLocation, splitMap, p);
            }
            else if (key.Key == ConsoleKey.D || key.Key == ConsoleKey.RightArrow)
            {
                newLocation = currentLocation + 1; // Move right
                relocate.relocate(mapData, currentLocation, newLocation, splitMap, p);
            }
            else if (key.Key == ConsoleKey.A || key.Key == ConsoleKey.LeftArrow)
            {
                newLocation = currentLocation - 1; // Move left
                relocate.relocate(mapData, currentLocation, newLocation, splitMap, p);
            }
            else
            {
                Console.WriteLine("Please use WASD or arrow keys to move around");
            }
            // Rebuild the updated map string from the modified character array
            for (int i = 0; i < splitMap.Length; i++)
            {
                newData += splitMap[i];
            }

            // If the player did not move onto the exit tile, regenerate the room display
            if (mapData[currentLocation] != 'E')
            {
                room.Generate(newData, 10, 10);
            }

            return newData;
        }
    }
}
