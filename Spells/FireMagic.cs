using Pr5.Spells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr5
{
    public class FireMagic : Spell, IFireBall
    {
        public override int MagicCast()
        {
            return FireBall(); 
        }

        public int FireBall()
        {
            return 20;
        }

    }
}
