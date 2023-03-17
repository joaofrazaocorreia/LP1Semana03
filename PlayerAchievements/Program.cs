using System;

namespace PlayerAchievements
{
    class Program
    {
        [Flags]
        enum achievements
        {
            DefeatOptionalBoss = 1 << 0,
            FindHiddenLevel = 1 << 1,
            FinishGame = 1 << 2
        
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Insert number of players:");
            int n = int.Parse(Console.ReadLine());

            achievements[] achieved = new achievements[n];   

            string input="";

            for (int i = 0; i < n; i++)
            {
                achieved[i]=0;

                Console.WriteLine("Did player "+(i+1)+" DefeatOptionalBoss?"+
                                  " (Yes / No)");
                input = Console.ReadLine();
                if (input == "Yes")
                {
                    achieved[i] |= achievements.DefeatOptionalBoss;
                }

                Console.WriteLine("Did player "+(i+1)+" FindHiddenLevel?"+
                                  " (Yes / No)");
                input = Console.ReadLine();
                if (input == "Yes")
                {
                    achieved[i] |= achievements.FindHiddenLevel;
                }

                Console.WriteLine("Did player "+(i+1)+" FinishGame?"+
                                  " (Yes / No)");
                input = Console.ReadLine();
                if (input == "Yes")
                {
                    achieved[i] |= achievements.FinishGame;
                }
            }

             for (int i = 0; i < n; i++)
             {
                Console.Write("Player "+(i+1)+" has the achievements: ");
                
                if (achieved[i] != 0)
                {
                    Console.WriteLine(achieved[i]);
                }

                if ((achieved[i] & (achievements.DefeatOptionalBoss |
                     achievements.FindHiddenLevel |achievements.FinishGame)) ==
                    (achievements.DefeatOptionalBoss |
                     achievements.FindHiddenLevel | achievements.FinishGame))
                {
                    Console.WriteLine("Completionist!");
                }

                else if (achieved[i] == 0)
                {
                    Console.WriteLine("None");
                }
             }

        }
    }
}
