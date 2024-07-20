using System;
class HelloWorld {
    public static bool IsDivisibleBy7(int num){
        num = Math.Abs(num);
        while(num>10){
            int last = num % 10;
            num = num / 10 - 2 * last; 
        }
        return num == 0 || num == 7;
        
    }
  static void Main() {
    int num = 616;
        if (IsDivisibleBy7(num))
            Console.WriteLine("Divisible");
        else
            Console.WriteLine("Not Divisible");
    }
}
