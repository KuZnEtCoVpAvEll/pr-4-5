using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Pr5.Spells
{
    public class AirMagic: Spell, IAirBall
    {
        public override int MagicCast()
        {
            return AirBall();
        }

        public int AirBall()
        {
            return 15;
        }
    }
}
