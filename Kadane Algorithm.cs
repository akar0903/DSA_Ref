using System;

class Program
{
    // Kadane's Algorithm implementation
    static int Kadane(int[] arr)
    {

        int currentMax = arr[0];
        int globalMax = arr[0];


        for (int i = 1; i < arr.Length; i++)
        {

            currentMax = Math.Max(arr[i], currentMax + arr[i]);


            if (currentMax > globalMax)
            {
                globalMax = currentMax;
            }
        }

        return globalMax;
    }

    static void Main(string[] args)
    {
       
        int[] arr = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };

        int maxSum = Kadane(arr);

        Console.WriteLine("Maximum subarray sum is: " + maxSum);
    }
}
