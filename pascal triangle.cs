using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of rows for Pascal's Triangle: ");
        int rows = int.Parse(Console.ReadLine());

        PrintPascalsTriangle(rows);
    }

    static void PrintPascalsTriangle(int rows)
    {
        // Array to store the values of Pascal's Triangle
        int[,] triangle = new int[rows, rows];

        for (int i = 0; i < rows; i++)
        {
            // Each row starts with 1
            triangle[i, 0] = 1;
            triangle[i, i] = 1; // The diagonal values are also 1

            // Calculate values for each row
            for (int j = 1; j < i; j++)
            {
                triangle[i, j] = triangle[i - 1, j - 1] + triangle[i - 1, j];
            }
        }

        // Print the triangle
        for (int i = 0; i < rows; i++)
        {
            // Print leading spaces for alignment
            for (int j = 0; j < rows - i - 1; j++)
            {
                Console.Write(" ");
            }

            // Print the values in the current row
            for (int j = 0; j <= i; j++)
            {
                Console.Write(triangle[i, j] + " ");
            }

            Console.WriteLine();
        }
    }
}
