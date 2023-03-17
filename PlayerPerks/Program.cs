using System;

namespace PlayerPerks
{
    class Program
    {
        [Flags]
        enum perks
        {
            WaterBreathing,
            Stealth,
            AutoHeal,
            DoubleJump
        };

        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            int w=0;
            int a=0;
            int s=0;
            int d=0;
            bool known=true;

            foreach (char c in input)
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

                if (known)
                {
                    
                }
            }
        }
    }
}
