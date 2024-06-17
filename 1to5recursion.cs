using System;
class HelloWorld {
    
public static void Main(String[] args) {
    int start = int.Parse(Console.ReadLine());
    int end = int.Parse(Console.ReadLine());
    
    //Print(1); // calls the print method starting from 1
    Print(start,end);
  }
  static void Print(int start,int end){
      //if(n==5){
        //  Console.WriteLine(5);
        //  return;
      //}
      if(start>end){
          return;
      }
      //Console.WriteLine(n); // comes here and prints here 
      //Print(n+1); // and goes to this line
      Console.WriteLine(start);
      Print(start+1,end);
  }
}
