using System;
using System.Collections.Generic;

class MatrixZeroes
{
    public static void SetZeroes(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        
        HashSet<int> zeroRows = new HashSet<int>();
        HashSet<int> zeroCols = new HashSet<int>();
        
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] == 0)
                {
                    zeroRows.Add(i);
                    zeroCols.Add(j);
                }
            }
        }

        foreach (int row in zeroRows)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[row, j] = 0;
            }
        }

        foreach (int col in zeroCols)
        {
            for (int i = 0; i < rows; i++)
            {
                matrix[i, col] = 0;
            }
        }
    }

    public static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    public static void Main()
    {
        int[,] matrix = {
            {1, 2, 3, 4},
            {5, 0, 7, 8},
            {9, 10, 11, 12},
            {13, 14, 15, 0}
        };

        Console.WriteLine("Original Matrix:");
        PrintMatrix(matrix);

        SetZeroes(matrix);

        Console.WriteLine("Modified Matrix:");
        PrintMatrix(matrix);
    }
}
