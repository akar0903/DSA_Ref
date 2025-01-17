// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    static bool SubsetSum(int[] nums,int target){
        int n = nums.Length;
        bool[,] dp = new bool[n + 1,target + 1];
        for(int i=0;i<n;i++){
            dp[i,0] = true;
        }
        for(int i=1;i<=n;i++){
            for(int j=1;j<=target;j++){
                dp[i,j] = dp[i-1,j];
                if(j >= nums[i-1]){
                dp[i,j]=dp[i-1,j] || dp[i-1,j - nums[i-1]];}
            }
        }
        return dp[n,target];
    }
    public static void Main(string[] args)
    {
        int[] nums = { 3, 34, 4, 12, 5, 2 };
        int target = 9;

        Console.WriteLine(SubsetSum(nums, target)
            ? "Subset with given sum exists."
            : "No subset with given sum.");
    }
}
