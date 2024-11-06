// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter");
        int n = int.Parse(Console.ReadLine());
        Sum(n,0);
    }
    static void Sum(int n,int accumulator){
        if(n == 0){
            Console.WriteLine(accumulator);
            return;
        }
        Sum(n - 1,accumulator + n);
    }
}
