using System;
public class HelloWorld {
    static void rotate(int n,int[] arr){
        int count=0;
        for(int i=0;i<arr.Length;i++){
            for(int j=i+1;j<arr.Length;j++){
                if((arr[i]+arr[j])==n){
                    count++;
                }
            }
        }
        Console.WriteLine("Count of pairs is " + count);
    }
  static void Main() {
      int[] arr = new int[]{1,3,4,2};
      int n=6;
      rotate(n,arr);
  }
}
