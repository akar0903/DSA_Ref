// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    static int BalancedIndex(string str){
        int length = str.Length;
        int[] open = new int[length + 1];
        int[] close = new int[length + 1];
        open[0] = 0;
        close[length] = 0;
        for(int i=0;i<str.Length;i++){
            if(str[i] == '('){
                open[i + 1] = open[i] + 1; 
            }
            else{
                open[i + 1] = open[i];
            }
        }
        for(int i = str.Length-1;i>=0;i--){
            if(str[i] == ')'){
                close[i] = close[i + 1] + 1;
            }
            else{
                close[i] = close[i + 1];
            }
        }
        for(int i=0;i<=length;i++){
            if(open[i] == close[i]){
                return i;
            }
        }
        return -1;
    }
    public static void Main(string[] args)
    {
        string input = "((((()((())(()";
        int index = BalancedIndex(input);
        Console.WriteLine("Balanced index: " + index);
    }
}
