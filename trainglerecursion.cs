using System;
class HelloWorld {
public static void Main(String[] args){
    Triangle(4,0);
  }
  static void Triangle(int r,int c){
      if(r==0){
          return;
      }
      if(c<r){
          Console.WriteLine("*");
          Triangle(r,c+1);
      }
      else{
          //Triangle(r-1,0);
          Console.WriteLine();
          Triangle(r-1,0);
      }
  }
}
