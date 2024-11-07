// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        if(Prime(number,2)){
            Console.WriteLine("It is Prime");
        }
        else{
            Console.WriteLine("It is not a Prime");
        }
    }
    static bool Prime(int number,int divisor){
        if(number < 2){
            return false;
        }
        else if(divisor * divisor > number){
            return true;
        }
        return Prime(number,divisor + 1);
    }
}
