// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] arr = {1,1,2,3,3,4,4};
        int count = int.Parse(Console.ReadLine());
        Dictionary<int,int> freq = new Dictionary<int,int>();
        foreach(var num in arr){
            if(freq.ContainsKey(num)){
                freq[num]++;
            }
            else{
                freq[num] = 1;
            }
        }
        List<int> result = new List<int>();
        foreach(var kvp in freq){
            if(kvp.Value == count){
                result.Add(kvp.Key);
            }
        }
        if (result.Count > 0)
        {
            Console.WriteLine($"Elements appearing exactly {count} times:");
            Console.WriteLine(string.Join(", ", result));
        }
        else
        {
            Console.WriteLine($"No elements appear exactly {count} times.");
        }
    }
}
