using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr5
{
    public interface IDamageble
    {
        int Health { get; set; }
        public void TakeDamage(int damage);
        public void Death();
    }
}
