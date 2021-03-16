using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace PlayerOppgave
{
    class Player
    {
        private string Name;
        private int HealthPoints;
        //private Player[] player;

        public Player(string name, int healthPoints)
        {
            Name = name;
            HealthPoints = healthPoints;
        }

        public string ShowStats()
        {
            var description = "";
            description += $"{Name}: ";
            description += $"{HealthPoints}";
            return description;

        }

        public void Play(Player player2, Random random)
        {
            int winner = random.Next(2);
            if (winner > 0)
            {
                HealthPoints--;
                player2.HealthPoints++;
            }
            else
            {
                HealthPoints++;
                player2.HealthPoints--;
            }

        }
    }
}
