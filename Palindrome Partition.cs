using System;
using System.Collections.Generic;
public class HelloWorld
{
    public static List<List<string>> Partition(string s){
        List<List<string>> result = new List<List<string>>();
        List<string> currentPartition = new List<string>();
        BackTrack(s,0,currentPartition,result);
        return result;
    }
    private static void BackTrack(string s,int start,List<string> currentPartition,List<List<string>> result){
        if(start == s.Length){
            result.Add(new List<string> (currentPartition));
            return;
        }
    
    for(int end = start;end <s.Length;end++){
        if(IsPalindrome(s,start,end)){
            currentPartition.Add(s.Substring(start,end-start+1));
            BackTrack(s, end + 1, currentPartition, result);
            currentPartition.RemoveAt(currentPartition.Count - 1);
        }
    }
    }
     private static bool IsPalindrome(string s, int left, int right)
    {
        while (left < right)
        {
            if (s[left] != s[right])
                return false;

            left++;
            right--;
        }
        return true;
    }
     public static void Main(string[] args)
    {
        string input = "aab";
        List<List<string>> partitions = Partition(input);

        Console.WriteLine("All possible palindrome partitions:");
        foreach (var partition in partitions)
        {
            Console.WriteLine(string.Join(", ", partition));
        }
    }
}
