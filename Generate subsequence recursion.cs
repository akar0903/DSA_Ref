using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] arr = {1,2,3};
        List<List<int>> result = new List<List<int>>();
        Subseq(arr, 0, new List<int>(), result);
        Console.WriteLine("Subsequences");
        foreach(var subsequence in result){
            Console.WriteLine(string.Join(", ", subsequence));
        }
    }
    static void Subseq(int[] arr,int index,List<int> current,List<List<int>> result){
        if(index == arr.Length){
            result.Add(new List<int>(current));
            return;
        }
        Subseq(arr, index + 1, current, result);
        current.Add(arr[index]);
        Subseq(arr, index + 1, current, result);
        current.RemoveAt(current.Count - 1);
    }
}
