using System;
class HelloWorld {
public static void Main(String[] args) {
  int[] arr = {3,4,5,6};
  Console.WriteLine(sorted(arr,0));
}
  static bool sorted(int[] arr,int index){
      if(index == arr.Length-1){
          return true;
      }
      return arr[index]<arr[index+1] && sorted(arr,index+1);
  }
}
