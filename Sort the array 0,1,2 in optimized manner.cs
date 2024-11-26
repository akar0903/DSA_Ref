// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] arr = {0,1,2,0,1,2,0,1,2,0,1,2};
        int n = arr.Length;
        int cnt0 = 0;
        int cnt1 = 0;
        int cnt2 = 0;
        for(int i=0;i<n;i++){
            if(arr[i] == 0) cnt0++;
            else if(arr[i] == 1) cnt1++;
            else cnt2++;
        }
        for(int i=0;i<cnt0;i++){
            arr[i] = 0;
        }
        for(int i=cnt0;i<cnt0+cnt1;i++){
            arr[i] = 1;
        }
        for(int i=cnt0+cnt1;i<n;i++){
            arr[i] = 2;
        }
        Console.WriteLine(string.Join(",",arr));
    }
}
