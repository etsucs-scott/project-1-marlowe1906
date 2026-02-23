using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame.Core
{
    // Represents the player character in the game
    // Implements ICharecter, meaning it must define combat behavior
    public class Player : ICharecter
    {
        // Core combat properties required by the interface
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public List<string> inventory = new List<string>() { "Wood Sword" };

        // Executes an attack on another character
        // Uses polymorphism since the target can be any ICharecter
        public void attack(ICharecter target)
        {
            Console.WriteLine($"{Name} used an attack! they did {AttackPower} damage!");
            target.takeDamage(AttackPower);
        }

        // Reduces player health when damage is received
        public void takeDamage(int Attack)
        {
            Console.WriteLine($"Oh no! {Name} took {Attack} damage!");
            Health -= Attack;
        }
    }
}
