using System;

namespace HeroPerks
{
    [Flags]
    enum Perks
    {
        WaterBreathing = 1 << 0,
        Stealth = 1 << 1,
        AutoHeal = 1 << 2,
        DoubleJump = 1 << 3
    }

    class Program
    {
        static void Main(string[] args)
        {

            string input = args[0];
            Perks playerPerks = 0;

            foreach (char c in input)
            {
                switch (c)
                {
                    case 'w':
                        playerPerks ^= Perks.WaterBreathing;
                        break;
                    case 'a':
                        playerPerks ^= Perks.Stealth;
                        break;
                    case 's':
                        playerPerks ^= Perks.AutoHeal;
                        break;
                    case 'd':
                        playerPerks ^= Perks.DoubleJump;
                        break;
                    default:
                        Console.WriteLine("Unknown perk!");
                        return;
                }
            }

            if (playerPerks == 0)
            {
                Console.WriteLine("No perks at all!");
            }
            else
            {
                Console.WriteLine(playerPerks);
            }
        }
    }
}