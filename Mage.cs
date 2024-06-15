using Pr5.Spells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr5
{

    public class Mage : Player
    {
        private byte magicLevel;
        public byte MagicLevel => magicLevel;
        Magic magic;
        public Mage(string name, byte magicLevel) : base(name)
        {
            //action += Death;
            
            this.magicLevel = magicLevel;
            magic = new Magic();
        }

        public override void Attack(Player target)
        {

            Console.WriteLine($"{Name} select magic element to attack: \n'Fire'\n'Water\n'Air'");

            target.TakeDamage(Defend((Mage)target, magic.MagicCast(Console.ReadLine()) * MagicLevel));

            Console.WriteLine("Press any key to view result");
            Console.ReadLine();

        }

        public override void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health <= 0)
            {
                Health = 0;
                base.TakeDamage(damage);
                //Death();
            }
        }

        public override int Defend(Mage target, int power)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"{target.Name} Select magic element to defend: \n'Fire'\n'Water\n'Air'");
            int targetPower = target.magic.MagicCast(Console.ReadLine()) * target.MagicLevel;
            Console.ForegroundColor = ConsoleColor.Gray;

            if (power >= targetPower)
            {
                Console.WriteLine($"{Name} dealt {power - targetPower} damage to {target.Name}");
                return power - targetPower;
            }
            else
            {
                if (targetPower - power != 0)
                {
                    Console.WriteLine($"{Name} get {(power - targetPower) * -1} damage from {target.Name}");
                }
                TakeDamage(targetPower - power);
                return 0;

            }

        }
        public override void Death()
        {
            Console.WriteLine($"{Name} is dead!");
        }



    }
}


