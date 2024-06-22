using System;
class HelloWorld {
public static void Main(String[] args) {
    int target = int.Parse(Console.ReadLine());
    fun(1,target+1);
    Console.WriteLine("");
    fun1(target,0);
  }
  static void fun(int n,int target){
      if(n==target){
          return;
      }
      Console.WriteLine(n);
      fun(n+1,target);
  }
  static void fun1(int n, int target){
      if(n==target){
          return;
      }
      Console.WriteLine(n);
      fun1(n-1,target);
  }
}
