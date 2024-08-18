// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;

public class HelloWorld
{
    static long Grid(int m,int n,Dictionary<string,long> memo)
    {
        string key = m.ToString() + "," + n.ToString();
        if(memo.ContainsKey(key)){
            return memo[key];
        }
        if (m == 1 && n == 1) return 1;
        if (m == 0 || n == 0) return 0;
        memo[key] = Grid(m-1,n,memo)+Grid(m,n-1,memo);
        return memo[key];
    }
    public static void Main(string[] args)
    {
        var memo = new Dictionary<string, long>();
        Console.WriteLine(Grid(2, 3, memo)); 
        Console.WriteLine(Grid(18, 18, memo));
    }
}
