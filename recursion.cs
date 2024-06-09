using System;

class Recursion
{
    static int cnt = 0;

    static void Print()
    {
        // Base condition - if count reaches 3 stops calling and prints the values
        if (cnt == 3) 
           return ;
        
        Console.WriteLine(cnt);

        // Count incremented
        cnt = cnt + 1;
        Print();
    }

    public static void Main(string[] args)
    {
        Print(); // prints 0 1 2
        Console.WriteLine(cnt); //prints 3
    }
}
