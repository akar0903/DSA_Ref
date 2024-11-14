// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;
public class SubSetCalculator{
    public static List<int> FindSubSetSums(int[] arr){
        List<int> subsetsums = new List<int>();
        CalculateSubSetSum(arr,0,0,subsetsums);
        return subsetsums;
    }
    public static void CalculateSubSetSum(int[] arr,int index,int current, List<int> subsetsums){
        if(index == arr.Length){
            subsetsums.Add(current);
            return;
        }
        CalculateSubSetSum(arr,index + 1,current+arr[index],subsetsums);
        CalculateSubSetSum(arr,index + 1,current,subsetsums);
    }
}

public class HelloWorld
{
    public static void Main()
    {
        int[] arr = {1,2,3};
        List<int> subsetsums = SubSetCalculator.FindSubSetSums(arr);
        subsetsums.Sort((a,b)=>b.CompareTo(a));
        Console.WriteLine("Sums of all subsets: [" + string.Join(", ", subsetsums) + "]");
    }
}
