using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr5.Spells
{
    public class WaterMagic: Spell, IWaterBall
    {
        public override int MagicCast()
        {
            return WaterBall();
        }

        public int WaterBall() 
        {
            return 25;
        }
    }
}
