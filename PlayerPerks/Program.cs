using System;

namespace PlayerPerks
{
    class Program
    {
        [Flags]
        enum perks
        {
            WaterBreathing = 0,
            Stealth = 0,
            AutoHeal = 0,
            DoubleJump = 0
        };

        static void Main(string[] args)
        {
            perks myPerks = perks.WaterBreathing | perks.Stealth | perks.AutoHeal | perks.DoubleJump;

            int w=0;
            int a=0;
            int s=0;
            int d=0;
            bool known=true;

            foreach (char c in args[0])
            {
                if (c==char.Parse("w"))
                {
                    w+=1;
                }

                else if (c==char.Parse("a"))
                {
                    a+=1;
                }

                else if (c==char.Parse("s"))
                {
                    s+=1;
                }

                else if (c==char.Parse("d"))
                {
                    d+=1;
                }

                else
                {
                    known=false;
                }
            }

            if (known)
            {
                if (w==0 ^ w%2==0)
                {
                    myPerks ^= perks.WaterBreathing;
                }

                if (a==0 ^ a%2==0)
                {
                    myPerks ^= perks.AutoHeal;
                }

                if (s==0 ^ s%2==0)
                {
                    myPerks ^= perks.Stealth;
                }

                if (d==0 ^ d%2==0)
                {
                    myPerks ^= perks.DoubleJump;
                }

                int[] array= new int[4] {w,a,s,d};
                foreach (int n in array)
                {
                    Console.WriteLine(n);
                }


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
