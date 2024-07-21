using System;
class HelloWorld {
    public static int min(int[] arr,int n){
        int min= arr[0];
        for(int i=0;i<n;i++){
            if(arr[i]<min){
                min=arr[i];
            }
        }
        return min;
    }
  static void Main() {
    int[] arr = {5,6,1,3,4};
    int n= arr.Length;
    Console.WriteLine(min(arr,n));
  }
}
