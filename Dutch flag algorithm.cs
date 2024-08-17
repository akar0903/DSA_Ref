using System;

class Program
{
    static void DutchFlagSort(int[] array)
    {
        int low = 0;
        int mid = 0;
        int high = array.Length - 1;

        while (mid <= high)
        {
            if (array[mid] == 0)
            {
                // Swap the current element with the element at 'low'
                Swap(array, low, mid);
                low++;
                mid++;
            }
            else if (array[mid] == 1)
            {
                // Move to the next element if the current element is 1
                mid++;
            }
            else
            {
                // Swap the current element with the element at 'high'
                Swap(array, mid, high);
                high--;
            }
        }
    }

    static void Swap(int[] array, int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }

    static void Main(string[] args)
    {
        // Example array with values 0, 1, and 2
        int[] array = { 2, 0, 2, 1, 1, 0 };

        // Print the array before sorting
        Console.WriteLine("Array before sorting: " + string.Join(", ", array));

        // Call the DutchFlagSort method
        DutchFlagSort(array);

        // Print the array after sorting
        Console.WriteLine("Array after sorting: " + string.Join(", ", array));
    }
}
