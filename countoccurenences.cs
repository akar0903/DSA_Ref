using System;

class HelloWorld {
    static int ReverseArrayExtraArray(int[] arr,int x) {
        int count = 0;
        for(int i=0;i<arr.Length;i++){
            if(arr[i] == x){
                count++;
            }
        }
        return count;
      
    }

    static void Main() {
    int[] arr = {12,2,2,1,2,2,2,5};
    int x = 2;
    Console.WriteLine(ReverseArrayExtraArray(arr,x));
    }
}
