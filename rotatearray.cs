using System;

class HelloWorld {
    static int[] Rotate(int[] arr) {
        int last = arr[arr.Length - 1];
        for (int i = arr.Length - 1; i > 0; i--) {
            arr[i] = arr[i - 1];
        }
        arr[0] = last;
        return arr;
    }

    static void Main() {
        int[] arr = new int[]{1, 2, 3, 4, 5};
        arr = Rotate(arr);  

        Console.WriteLine("Rotated Array is");
        string rotatedArray = string.Join(" ", arr);
        Console.WriteLine(rotatedArray);
    }
}
