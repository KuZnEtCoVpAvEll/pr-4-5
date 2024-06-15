using Pr5.Spells;
using System;


namespace Pr5
{
    public class Magic
    {
        Spell[] spells = new Spell[3];
        public int MagicCast(string element)
        {
            SpellsInitialization();
            switch (element)
            {
                case "Fire":
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Fireball");
                        return spells[0].MagicCast();

                    }
                case "Water":
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Waterball");
                        return spells[1].MagicCast();

                    }
                case "Air":
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Airball");
                        return spells[2].MagicCast();
                    }
                default:
                    {
                        Console.WriteLine("Error");
                        return 0;
                    }
            }
        }


        private void SpellsInitialization()
        {
            spells[0] = new FireMagic();
            spells[1] = new WaterMagic();
            spells[2] = new AirMagic();
        }
    }
}

