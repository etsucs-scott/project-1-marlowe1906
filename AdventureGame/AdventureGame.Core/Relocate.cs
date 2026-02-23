using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame.Core
{
    // Handles validating movement and updating player position
    internal class Relocate
    {
        // Executes movement logic based on what is at the new location
        public void relocate(string mapData, int currentLocation, int newLocation, char[] splitMap, Player p)
        {
            Attack attack = new Attack();
            MonsterCheck monsters = new MonsterCheck();
            Potion potion = new Potion();
            Random random = new Random();
            WeaponChance weapon = new WeaponChance();

            // Normal movement onto empty tile
            if (newLocation < 0 || newLocation >= mapData.Length)
            {
                Console.WriteLine("Cant go there!");
                Console.WriteLine();
                
            }
            // OOB protection
            else if (mapData[newLocation] == '.')
            {
                splitMap[currentLocation] = '.';
                splitMap[newLocation] = 'P';
            }
            // Potion pickup
            else if (mapData[newLocation] == 'I')
            {
                int choice = random.Next(0, 2);
                if (choice == 0)
                {
                    potion.retrieve(p);
                }
                else
                {
                    weapon.choose(mapData, currentLocation, newLocation, splitMap, p);
                }
                splitMap[currentLocation] = '.';
                splitMap[newLocation] = 'P';
            }
            // Monster encounter triggers combat
            else if (mapData[newLocation] == 'M')
            {
                string result = attack.sequence(p);

                // Player moves only if they win the battle
                if (result == "Win")
                {
                    Console.Clear();
                    splitMap[currentLocation] = '.';
                    splitMap[newLocation] = 'P';
                }
                // Player remains in place if they lose
                else
                {
                    Console.Clear();
                    splitMap[currentLocation] = 'P';
                    splitMap[newLocation] = '.';
                }
            }
            // Exit tile logic
            else if (mapData[newLocation] == 'E')
            {
                // Player cannot exit if monsters still exist on the map
                if (monsters.checkForMonsters(mapData) == true)
                {
                    Console.WriteLine("You cant escape yet! There are still monsters!");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Hooray, you won!");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("You cant move there");
            }
        }
    }
}
