using System;
class HelloWorld {
public static void Main(String[] args) {
    Console.WriteLine(sum(1342));
  }
  static int sum(int n){
      if(n==0){
          return 0;
      }
      return (n%10)+sum(n/10);
  }
}
