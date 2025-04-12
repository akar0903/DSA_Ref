using System;
using System.Collections.Generic;
public class HelloWorld
{
    public static bool IsValid(string s){
        var stack = new Stack<char>();
        var map = new Dictionary<char,char>{
            {'}','{'},
            {')','('},
            {']','['},
        };
        foreach(var c in s){
            if(map.ContainsValue(c)){
                stack.Push(c);
            }
            else{
                if(stack.Count == 0 || stack.Pop() != map[c]){
                    return false;
                }
            }
        }
        return stack.Count == 0;
    }
    static void Main(string[] args)
    {
        string[] testInputs = {
            "()[]{}",       // valid
            "({[]})",       // valid
            "(]",           // invalid
            "({[})]",       // invalid
            "]})({[",       // invalid
            "(((())))",     // valid
            "{"             // invalid
        };
        foreach (var input in testInputs)
        {
            bool result = IsValid(input);
            Console.WriteLine($"Input: {input} → Valid? {result}");
        }
    }
}
