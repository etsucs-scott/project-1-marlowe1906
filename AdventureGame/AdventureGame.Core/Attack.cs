using System;
using System.Collections.Generic;
using System.Diagnostics;
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

            
            // Half second timer

            // Initialize monster stats for this battle
            m.Health = 100;
            m.AttackPower = 10;

            bool battle = true;
            Console.Clear();

            while (battle == true)
            {
                int time = random.Next(500,1000);

                Console.Clear();
                Console.WriteLine("Get ready to attack!");

                Thread.Sleep(time);

                
                Console.WriteLine("ATTACK NOW!");

                Stopwatch timer = Stopwatch.StartNew();

                bool attacked = false;

                while (timer.ElapsedMilliseconds < 500)
                {
                    if (Console.KeyAvailable)
                    {
                        Console.ReadKey(true); // consume the key press
                        Console.WriteLine($"You hit the monster! You did {p.AttackPower} Damage!");
                        m.Health -= p.AttackPower;
                        attacked = true;
                        break;
                    }
                }

                if (!attacked)
                {
                    Console.WriteLine("Not quite fast enough! The monster got you!");
                    p.Health -= m.AttackPower;
                }

                Console.WriteLine();
                Console.WriteLine(stats(p, m));
                Console.WriteLine();

                Console.WriteLine("Press any key to continue!");
                Console.ReadKey();

                if (m.Health <= 0)
                {
                    return "Win";
                    break;
                }
                else if (p.Health <= 0)
                {
                    return "Lose";
                    break;
                }
            }
            return "Incomplete Battle";
        }
    }
}
