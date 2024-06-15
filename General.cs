using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr5
{
    public static class General
    {
        public static void CalculatingWiner(Player player1, Player player2)
        {
            if (player2.Health <=0)
            {
                
                Console.WriteLine($"{player1.Name} is winner");
            }
            else
            {
                Console.WriteLine($"{player2.Name} is winner");
            }
        }

        public static void PrintRules()
        {
            Console.WriteLine("Rule:\nYou cannot use one type of spell in a row!");
            Console.WriteLine("Example:\nIf you used Fire for attack and defence, you cannot use it for attack and defence on your next turn");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
