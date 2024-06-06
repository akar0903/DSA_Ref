using System;

class HelloWorld {
  
    static bool linear(int[] array, int key) {
        for (int i = 0; i < array.Length; i++) {
            if (array[i] == key) {
                return true;
            }
        }
        return false;
    }

    static void Main() {
        int[] array = {1, 2, 3, 4, 5};
        bool result = linear(array, 5);
        Console.WriteLine(result);
    }
}
