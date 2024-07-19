
using System;
class HelloWorld {
    static int getmin(int []arr){
        int res = arr[0];
        for(int i=0;i<arr.Length;i++){
            res = Math.min(res,arr[i]);
        }
        return res;
    }
    static int getmax(int []arr){
        int res = arr[0];
        for(int i=0;i<arr.Length;i++){
            res= Math.max(res,arr[i]);
        }
        return res;
    }
  static void Main() {
    int []arr= {1,2,3,4};
    Console.WriteLine(getmin(arr));
    Console.WriteLine(getmax(arr));
  }
}
