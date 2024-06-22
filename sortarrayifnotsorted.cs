using System;
class HelloWorld {
public static void Main(String[] args) {
  int[] arr = {3,5,4,6};
  if(sorted(arr,0)){
      Console.WriteLine(string.Join(", ",arr));
  }
  else{
      Array.Sort(arr);
      Console.WriteLine(string.Join(", ",arr));
  }
}
  static bool sorted(int[] arr,int index){
      if(index == arr.Length-1){
          return true;
      }
      return arr[index]<arr[index+1] && sorted(arr,index+1);
  }
}
