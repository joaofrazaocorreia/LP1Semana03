using System;

namespace PlayerPerks
{
    class Program
    {
        [Flags]
        enum perks
        {
            WaterBreathing = 1 << 0,
            AutoHeal= 1 << 2,
            Stealth= 1 << 3,
            DoubleJump= 1 << 4
        };

        static void Main(string[] args)
        {
            perks myPerks = 0;

            bool known=true;

            foreach (char c in args[0])
            {
                if (c==char.Parse("w"))
                {
                    myPerks ^= perks.WaterBreathing;
                }

                else if (c==char.Parse("a"))
                {
                    myPerks ^= perks.AutoHeal;
                }

                else if (c==char.Parse("s"))
                {
                    myPerks ^= perks.Stealth;
                }

                else if (c==char.Parse("d"))
                {
                    myPerks ^= perks.DoubleJump;
                }

                else
                {
                    known=false;
                }
            }

            if (known)
            {
                if (myPerks != 0)
                {
                    Console.WriteLine(myPerks);
                }

                else
                {
                    Console.WriteLine("No perks at all!");
                } 

                if ((myPerks & perks.Stealth) == perks.Stealth)
                {
                    if ((myPerks & perks.DoubleJump) == perks.DoubleJump)
                    {
                        Console.WriteLine("Silent Jumper!");
                    }
                }

                if ((myPerks & perks.AutoHeal) != perks.AutoHeal)
                {
                    Console.WriteLine("Not gonna make it!");
                }
            }

            else
            {
                Console.WriteLine("Unknown Perk!");
            }
        }
    }
}
