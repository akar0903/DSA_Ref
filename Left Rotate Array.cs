// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] arr = {1,2,3,4,5,6,7};
        int k = 3;
        LeftRotate(arr,k);
        Console.WriteLine(string.Join(",",arr));
    }
    public static void LeftRotate(int[] arr,int k){
        int n = arr.Length;
        if(k==0|| arr.Length==0){
            return;
        }
        Reverse(arr,0,k-1);
        Reverse(arr,k,n-1);
        Reverse(arr,0,n-1);
    }
    public static void Reverse(int[] arr,int start,int end){
        while(start<end){
            int temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;
            start++;
            end--;
        }
    }
}
