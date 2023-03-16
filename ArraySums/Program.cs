using System;

namespace ArraySums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give array height: ");
            string height = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Give array length: ");
            string length = Console.ReadLine();
            Console.WriteLine();

            int h = int.Parse(height);
            int l = int.Parse(length);

            float[,] matrix = new float[h , l];
            string input="";
            float value = 0.0f;

            for (int i=0; i < matrix.GetLength(0); i++)
            {
                for (int j=0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("Insert value ["+i+","+j+"] : ");
                    input = Console.ReadLine();
                    Console.WriteLine();

                    value= float.Parse(input);
                    matrix[i , j] = value;
                }
            }

            float lineSum = 0.0f;
            for (int i=0; i < matrix.GetLength(0); i++)
            {
                lineSum = 0.0f;
                for (int j=0; j < matrix.GetLength(1); j++)
                {
                    lineSum += matrix[i,j];
                }
                Console.WriteLine("The total sum of row "+(i+1)+" is "+lineSum);
            }

            float colSum = 0.0f;
            for (int i=0; i < matrix.GetLength(1); i++)
            {
                colSum = 0.0f;
                for (int j=0; j < matrix.GetLength(0); j++)
                {
                    colSum += matrix[j,i];
                }
                Console.WriteLine("The total sum of column "+
                                (i+1)+" is "+colSum);
            }
        }
    }
}
