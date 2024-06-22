using System;
class HelloWorld {
    public static void Main(String[] args) {
        int[] arr = {1, 2, 3, 4, 5};
        int target = 5;
        Console.WriteLine(search(arr, target, 0, arr.Length - 1));
    }

    static int search(int[] arr, int target, int s, int e) {
        if (s > e) {
            return -1;
        }
        int m = s + (e - s) / 2;
        if (target == arr[m]) {
            return m;
        }
        if (target < arr[m]) {
            return search(arr, target, s, m - 1);
        }
        return search(arr, target, m + 1, e);
    }
}
