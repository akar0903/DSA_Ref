using System;
using System.Collections.Generic;

public class HelloWorld
{
    static List<int> Intersection(int[] arr1, int[] arr2,int[] arr3)
    {
        int n = arr1.Length;
        int m = arr2.Length;
        int l = arr3.Length;
        int i = 0;
        int j = 0;
        int k = 0; 
        List<int> IntersectionResult = new List<int>();
        while (i < n && j < m && k < l)
        {
            if (i > 0 && arr1[i] == arr1[i - 1])
            {
                i++;
                continue;
            }
            if (j > 0 && arr2[j] == arr2[j - 1])
            {
                j++;
                continue;
            }
            if(k > 0 && arr3[k] == arr3[k -1]){
                k++;
                continue;
            }
            if (arr1[i] == arr2[j] &&  arr1[i] == arr3[k])
            {
                IntersectionResult.Add(arr1[i]); 
                i++;
                j++;
            }
            else if (arr1[i] < arr2[j] && arr1[i] < arr3[k])
            {
                i++; 
            }
            else if(arr2[j] < arr1[i] && arr2[j] < arr3[k])
            {
                j++; 
            }
            else{
                k++;
            }
        }
        return IntersectionResult;
    }
    public static void Main(string[] args)
    {
        int[] arr1 = { 1, 2, 2, 3, 4 ,6};
        int[] arr2 = { 2, 2, 5, 6 };
        int[] arr3 = {2,6,7};
        List<int> result = Intersection(arr1, arr2, arr3);
        Console.WriteLine(string.Join(",", result)); 
    }
}
