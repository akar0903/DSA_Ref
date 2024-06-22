using System;

class HelloWorld {
    public static void Main(String[] args) {
        int[] arr = {6, 5, 4, 3, 2};
        selection(arr, arr.Length, 0, 0);
        Console.WriteLine(string.Join(", ", arr));
    }

    static void selection(int[] arr, int r, int c, int max) {
        if (r == 0) {
            return;
        }

        if (c < r) {
            if (arr[c] > arr[max]) {
                selection(arr, r, c + 1, c); // Update max if a larger element is found
            } else {
                selection(arr, r, c + 1, max); // Continue checking the next element
            }
        } else {
            // Swap the found maximum element with the last element of the unsorted portion
            int temp = arr[max];
            arr[max] = arr[r - 1];
            arr[r - 1] = temp;

            // Move to the next pass
            selection(arr, r - 1, 0, 0);
        }
    }
}
