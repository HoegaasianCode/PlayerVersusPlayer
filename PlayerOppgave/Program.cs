using System;
using System.Security.Cryptography.X509Certificates;

namespace PlayerOppgave
{
    class Program
    {
        /// <summary>
        /// The task is to simulate a basic "game mechanical" tournament scenario, where the 
        /// combatants are randomly chosen.
        /// Great for learning the basics of randomization and modulus beyond pure checks for odd/even numbers.
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {
            var random = new Random();
            var players = new[] { new Player("Per", 10), new Player("Pål", 10), new Player("Espen", 10) };
            for (var round = 1; round <= 10; round++)
            {
                
                var playerIndex1 = random.Next(players.Length); // random number 0-2
                var playerIndex2 = (playerIndex1 + 1 + random.Next(2)) % players.Length;
                var player1 = players[playerIndex1];
                var player2 = players[playerIndex2];
                player1.Play(player2, random); // (static function) Player.Play(player1, player2, random);
            }

            foreach (var player in players)
            {
                Console.WriteLine(player.ShowStats());
                
            }
        }
    }
}
