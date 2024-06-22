using System;
class HelloWorld {
public static void Main(String[] args){
    int[] arr = {6,5,4,3,2};
    bubble(arr,arr.Length-1,0);
    Console.WriteLine(string.Join(", ",arr));
  }
  static void bubble(int[] arr,int r,int c){
      if(r==0){
          return;
      }
      if(c<r){
          if(arr[c]>arr[c+1]){
              int temp = arr[c];
              arr[c]=arr[c+1];
              arr[c+1]= temp;
          }
          bubble(arr,r,c+1);
      }
      else{
          //Triangle(r-1,0);
          Console.WriteLine();
          bubble(arr,r-1,0);
      }
  }
}
