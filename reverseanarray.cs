using System;

class HelloWorld {
    static void ReverseArrayExtraArray(int[] arr) {
        int[] rev = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++) {
            rev[i] = arr[arr.Length - i - 1];
        }
        foreach (int num in rev) {
            Console.Write(num + " ");
        }
        Console.WriteLine(); // To move to the next line after printing the array
    }

    static void Main() {
        int[] originalArr = {1, 2, 3, 4, 5};
        ReverseArrayExtraArray(originalArr);
    }
}
