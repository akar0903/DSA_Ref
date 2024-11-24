// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] arr = {1,1,2,3,3,4,4};
        int number = 2;
        int numcount = 0;
        int count = int.Parse(Console.ReadLine());
        for(int i=0;i<arr.Length;i++){
            if(number == arr[i]){
                numcount++;
            }
        }
        if(numcount == 1){
            Console.WriteLine(number);
        }
        else{
            Console.WriteLine("Count is greater than 1");
        }
    }
}
