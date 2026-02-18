using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame.Core
{
    // Represents an enemy in the game that can attack and take damage
    // Implements the ICharecter interface, meaning it must define combat behavior
    public class Monster : ICharecter
    {
        // Basic combat properties required by the interface
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }

        // Performs an attack on another character
        // Calls the target's takeDamage method using this monster's AttackPower
        public void attack(ICharecter target)
        {
            Console.WriteLine($"{Name} used an attack! they did {AttackPower} damage!");
            target.takeDamage(AttackPower);
        }

        // Reduces the monster's health when it receives damage
        public void takeDamage(int Attack)
        {
            Console.WriteLine($"Hooray! The Monster took {Attack} damage!");
            Health -= Attack;
        }
    }
}
