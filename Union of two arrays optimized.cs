using System;
using System.Collections.Generic;

public class HelloWorld
{
    static List<int> Union(int[] arr1, int[] arr2)
    {
        int n = arr1.Length;
        int m = arr2.Length;
        int i = 0;
        int j = 0;
        List<int> UnionResult = new List<int>();
        while (i < n && j < m)
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
            if (arr1[i] < arr2[j])
            {
                UnionResult.Add(arr1[i]);
                i++;
            }
            else if (arr2[j] < arr1[i])
            {
                UnionResult.Add(arr2[j]);
                j++;
            }
            else
            {
                UnionResult.Add(arr1[i]);
                i++;
                j++;
            }
        }
        while (i < n)
        {
            if (i > 0 && arr1[i] != arr1[i - 1])
            {
                UnionResult.Add(arr1[i]);
            }
            else if (i == 0) 
            {
                UnionResult.Add(arr1[i]);
            }
            i++;
        }
        while (j < m)
        {
            if (j > 0 && arr2[j] != arr2[j - 1] && !UnionResult.Contains(arr2[j]))
            {
                UnionResult.Add(arr2[j]);
            }
            else if (j == 0 && !UnionResult.Contains(arr2[j])) 
            {
                UnionResult.Add(arr2[j]);
            }
            j++;
        }

        return UnionResult;
    }

    public static void Main(string[] args)
    {
        int[] arr1 = { 1, 2, 2, 3, 4 };
        int[] arr2 = { 5, 5, 6, 2 };
        List<int> result = Union(arr1, arr2);
        Console.WriteLine(string.Join(",", result));
    }
}
