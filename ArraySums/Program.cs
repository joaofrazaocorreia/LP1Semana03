using System;

namespace ArraySums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give array height: ");
            string height=Console.ReadLine();
            Console.WriteLine();

            Console.Write("Give array length: ");
            string length=Console.ReadLine();
            Console.WriteLine();

            int h = int.Parse(height);
            int l = int.Parse(length);

            int[] matrix = new int [h , l];
        }
    }
}
