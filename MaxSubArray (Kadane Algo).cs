using System;
public class HelloWorld
{
    static int MaxSum(int[] arr){
        int maxSum = int.MinValue;
        int currentSum = 0;
        foreach(int num in arr){
            currentSum += num;
            maxSum = Math.Max(currentSum,maxSum);
            if(currentSum < 0){
                currentSum = 0;
            }
        }
        return maxSum;
    }
    public static void Main(string[] args)
    {
        int[] arr = {-4,-3,-2,-1,0,1,2,3,4};
         Console.WriteLine("Maximum Subarray Sum: " + MaxSum(arr));
    }
}
