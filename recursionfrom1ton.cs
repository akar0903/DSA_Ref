using System;

class Recursion
{
    static void PrintNumbers(int number, int remainingPrints)
    {
        // Base case: If remainingPrints is 0 or less, return
        if (remainingPrints <= 0) return;
        
        // Print the number
        Console.WriteLine(number);
        
        // Recursive call with decremented remainingPrints and incremented number
        PrintNumbers(number + 1, remainingPrints - 1);
    }

    public static void Main(string[] args)
    {
        // Prompt the user to enter a number
        Console.WriteLine("Enter a number:");
        int n = int.Parse(Console.ReadLine());
        
        // Call the recursive function to print numbers from 1 to n
        PrintNumbers(1, n); // Print numbers from 1 to n, n times
    }
}
