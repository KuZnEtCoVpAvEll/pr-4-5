using System;


namespace Pr5
{
    public class Game
    {
        public void StartGame()
        {
            Player player1 = PlayerInitialization(); 
            Player player2 = PlayerInitialization();
            
            
            player1.action += GameOver;
            player2.action += GameOver; 
            General.PrintRules();

            GamingProcess(player1,player2);
        }

        private Player PlayerInitialization()
        {
            
            Console.WriteLine("Enter the name of player: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the magic level (1-5): ");
            byte level = byte.Parse(Console.ReadLine());

            return new Mage(name, level);
            
        }

        private void GamingProcess(Player player1, Player player2)
        {
            while (player1.Health > 0 && player2.Health > 0)
            {
                player1.Attack(player2);
                Console.Clear();
                Console.WriteLine($"{player1.Name} HP: {player1.Health}\n{player2.Name} HP: {player2.Health}");
                if (player1.Health <= 0 || player2.Health <= 0)
                {
                    break;
                }
                player2.Attack(player1);
                Console.Clear();
                Console.WriteLine($"{player1.Name} HP: {player1.Health}\n{player2.Name} HP: {player2.Health}");
            }
            General.CalculatingWiner(player1, player2);

        }

        public void GameOver()
        {
            Console.WriteLine("GameOver");
        }
    }
}
