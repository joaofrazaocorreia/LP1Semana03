using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string givenString = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Enter a character: ");
            string character = Console.ReadLine();
            Console.WriteLine("");
            char givenChar = char.Parse(character);

            string output="";

            foreach (char c in givenString)
            {
                if (c != givenChar)
                {
                    output += c;
                }
            }

            Console.WriteLine("Output: "+output);
        }
    }
}
