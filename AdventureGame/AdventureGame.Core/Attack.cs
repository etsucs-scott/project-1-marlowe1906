using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame.Core
{
    // Handles combat logic between the player and a monster
    internal class Attack
    {
        // Displays current health values for both characters
        static string stats(Player p, Monster m)
        {
            Random random = new Random(); // Not used in this method

            return $"Player health: {p.Health} \nMonster health: {m.Health}";
        }

        // Runs the battle sequence and returns the result
        public string sequence(Player p)
        {
            Random random = new Random();
            Monster m = new Monster();

            // Initialize monster stats for this battle
            m.Health = 100;
            m.AttackPower = 10;

            bool battle = true;
            Console.Clear();

            while (battle == true)
            {
                int guess = random.Next(1, 11);
                int monsterGuess = random.Next(1, 11);

                Console.WriteLine();
                Console.WriteLine("Pick a number between 1 and 10");

                int userGuess = int.Parse(Console.ReadLine());

                if (userGuess == guess)
                {
                    Console.WriteLine("Wow a perfect hit! You one shot your opponent!");
                    Console.WriteLine(stats(p, m));
                    battle = false;
                    return "Win";
                }
                else if (userGuess == monsterGuess)
                {
                    Console.WriteLine("You and the monster both countered eachother at the same time! Nothing happens!");
                    Console.WriteLine(stats(p, m));
                }
                // Compares guess differences to decide who lands the hit
                else if ((userGuess - guess) > (monsterGuess - guess))
                {
                    Console.WriteLine("You hit the monster!");
                    m.takeDamage(p.AttackPower);
                    Console.WriteLine(stats(p, m));
                }
                else
                {
                    Console.WriteLine("The monster hit you!");
                    p.takeDamage(m.AttackPower);
                    Console.WriteLine(stats(p, m));
                }

                // Check win/lose conditions
                if (p.Health <= 0)
                {
                    Console.WriteLine("YOU DIED");
                    battle = false;
                    return "Lose";
                }
                else if (m.Health <= 0)
                {
                    Console.WriteLine("You beat the monster!");
                    battle = false;
                    return "Win";
                }
            }

            return "Incomplete Battle";
        }
    }
}
