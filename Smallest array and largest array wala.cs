// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Linq;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        //int num = 0;
        int[] arr = {9,10,4,7,34,1};
        int[] arr1 = {9,10,4,7,34,1};
        //var distinctArr = arr.Distinct().ToArray();
        int largest = int.MinValue;
        int secondlargest = int.MinValue;
        int thirdlargest = int.MinValue;
        int smallest = int.MaxValue;
        int secondsmallest = int.MaxValue;
        int thirdsmallest = int.MaxValue;
        if(arr == null || arr.Length < 3){
            Console.WriteLine("No third largest element");
            return;
        }
        if(arr1 == null || arr1.Length < 3){
            Console.WriteLine("No third smallest element");
            return;
        }
        for(int i=0;i<arr.Length;i++){
            if(arr[i]>largest){
                thirdlargest = secondlargest;
                secondlargest = largest;
                largest = arr[i];
            }
            //else if(arr[i] > secondlargest && arr[i] >)
            else if(arr[i] != largest && arr[i] > thirdlargest && arr[i] != secondlargest){
                thirdlargest = arr[i];
            }
        }
        for(int j=0;j<arr1.Length;j++){
            if(arr1[j]<smallest){
                thirdsmallest = secondsmallest;
                secondsmallest = smallest;
                smallest = arr1[j];
            }
            //else if(arr[i] > secondlargest && arr[i] >)
             else if (arr1[j] != smallest && arr1[j] < secondsmallest)
            {
                thirdsmallest = secondsmallest;
                secondsmallest = arr1[j];
            }
            else if(arr1[j] != smallest && arr1[j] > thirdsmallest && arr1[j] != secondsmallest){
                thirdsmallest = arr1[j];
            }
        }
        if (thirdlargest == int.MinValue)
        {
            Console.WriteLine("No third largest distinct element.");
        }
        else
        {
            Console.WriteLine($"The third largest distinct element is: {thirdlargest}");
        }
        if (thirdsmallest == int.MaxValue)
        {
            Console.WriteLine("No third largest distinct element.");
        }
        else
        {
            Console.WriteLine($"The third smallest distinct element is: {thirdsmallest}");
        }
    }
}
