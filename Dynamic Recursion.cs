using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        while(true)
        {
            Console.WriteLine("Enter the largest value");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the smallest value");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("The values are");
            if(i > n)
            {
                int sum = 0;
                int product = 1;
                Pattern(i, n, ref sum, ref product);
                Console.WriteLine($"Total Sum: {sum}");
                Console.WriteLine($"Total Product: {product}");
                break; 
            }
            else
            {
                Console.WriteLine("Invalid input. The largest value must be larger than the smallest value.");
            }
        }
    }
    static void Pattern(int i, int n, ref int sum, ref int product)
    {
        if(i < n)
        {
            return; 
        }
        //Console.WriteLine("The values are");
        Console.WriteLine(i);  
        sum += i;              
        product *= i;          
        Pattern(i - 1, n, ref sum, ref product);
    }
}
