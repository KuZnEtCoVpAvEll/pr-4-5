using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Pr5
{
    public abstract class Player: IDamageble
    {
        public event Action action;
        private string name;
        private int health;

        public string Name => name;
        
        public int Health 
        {
            get
            {
                return health;
            }
            set
            {
                health = value;
            }
        }
        
        
        public Player(string name)
        {
            this.name = name;
            Health = 100;
            action += Death;
        }
        public abstract void Attack(Player target);
        public abstract int Defend(Mage target, int power);

        public virtual void TakeDamage(int damage)
        {
            action.Invoke();
        }

        public abstract void Death();

       
    }

}
