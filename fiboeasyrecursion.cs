using System;
class HelloWorld {
public static void Main(string[] args) {
    int n = int.Parse(Console.ReadLine());
    Console.WriteLine(fibo(n));
  }
  static int fibo(int n){
      //base condition
      if(n<2){
          return n;
      }
      return fibo(n-1)+fibo(n-2); // returns value fibo(n)=fibo(n-1)+fibo(n-2);
  }
}
