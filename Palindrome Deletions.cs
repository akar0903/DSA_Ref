// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    static int MinDeletion(string str,int start,int end){
        if(start>=end){
            return 0;
        }
        if(str[start] == str[end]){
            return MinDeletion(str,start+1,end-1);
        }
        int deletefromstart = MinDeletion(str,start+1,end);
        int deletefromend = MinDeletion(str,start,end-1);
        return 1 + Math.Min(deletefromstart,deletefromend);
    }
    static int Palindrome(string str){
        return MinDeletion(str,0,str.Length-1);
    }
    public static void Main(string[] args)
    {
        string input = "abefbac";
        int result = Palindrome(input);
        Console.WriteLine("Minimum deletions required to make the string a palindrome: " + result);
    }
}
