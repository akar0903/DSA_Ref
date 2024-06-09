using System;

class Recursion
{
    static void PrintName(string name,int count){
        if(count==0) return;
        Console.WriteLine(name);
        PrintName(name,count-1); //decrementing my count to reach 0 to return 
    }
    public static void Main(string[] args){
        Console.WriteLine("Enter your name");
        string name = Console.ReadLine();
        Console.WriteLine("Enter the number of times you want to print");
        int count = int.Parse(Console.ReadLine());
        PrintName(name,count); //calls the recursive function to print name
    }
}
