using System;
using System.Collections.Generic;

public class HelloWorld {
    public static IList<int> MajorityElement(int[] nums) {
        if (nums == null || nums.Length == 0) {
            return new List<int>();
        }
        int candidate1 = 0, candidate2 = 0,candidate3=0, count1 = 0, count2 = 0, count3 = 0;
        foreach (int num in nums) {
            if (num == candidate1) {
                count1++;
            } else if (num == candidate2) {
                count2++;
            } 
            else if(num == candidate3){
                count3++;
            }else if (count1 == 0) {
                candidate1 = num;
                count1 = 1;
            } else if (count2 == 0) {
                candidate2 = num;
                count2 = 1;
            }
            else if(count3 == 0){
                candidate3 = num;
                count3 = 1;
            }
            else {
                count1--;
                count2--;
                count3--;
            }
        }
        count1 = 0;
        count2 = 0;
        count3 = 0;
        foreach (int num in nums) {
            if (num == candidate1) {
                count1++;
            } else if (num == candidate2) {
                count2++;
            }
            else if(num == candidate3){
                count3++;
            }
        }
        List<int> result = new List<int>();
        int threshold = nums.Length / 4;
        if (count1 > threshold) {
            result.Add(candidate1);
        }
        if (count2 > threshold) {
            result.Add(candidate2);
        }
         if (count3 > threshold) {
            result.Add(candidate3);
        }

        return result;
    }

    public static void Main(string[] args) {
        Console.WriteLine("Enter the elements of the array separated by spaces:");
        string input = Console.ReadLine();
        int[] nums = Array.ConvertAll(input.Split(' '), int.Parse);

        IList<int> majorityElements = MajorityElement(nums);
        Console.WriteLine("Majority elements (appearing more than ⌊n/4⌋ times):");
        Console.WriteLine(string.Join(", ", majorityElements));
    }
}
