using System;

class Program
{
    static void Main()
    {
        int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

        int r = matrix.GetLength(0);
        int c = matrix.GetLength(1);

        Console.WriteLine("Diagonal elements are: ");
        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                if (i == j)
                {
                    Console.Write(matrix[i, j] + " ");
                }
            }
        }
    }
}
