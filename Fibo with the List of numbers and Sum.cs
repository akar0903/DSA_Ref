// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        List<int> fiboSeq = new List<int>();
        for(int i=0;i<=n;i++){
            fiboSeq.Add(Fibo(i));
        }
        Console.WriteLine("Fibonacci sequence up to Fibo(" + n + "): " + string.Join(", ", fiboSeq));
        for(int i=0;i<=n;i++){
            sum += n;
        }
        Console.WriteLine(sum);
    }
    static int Fibo(int n){
        if(n<=1){
            return n;
        }
        return Fibo(n - 2)+Fibo(n - 1);
    }
}
