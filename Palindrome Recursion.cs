// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string pal = "madam";
        if(Palindrome(pal, 0, pal.Length - 1)){
            Console.WriteLine("It is Palindrome");
        }
        else{
            Console.WriteLine("It is not a Palindrome");
        }
    }
    static bool Palindrome(string pal,int start,int end){
        if(start >= end){
            return true;
        }
        if(pal[start] != pal[end]){
            return false;
        }
        return Palindrome(pal,start + 1,end - 1);
    }
}
