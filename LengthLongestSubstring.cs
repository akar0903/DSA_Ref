using System;
using System.Collections.Generic;

class Program
{
    public static int LengthOfLongestSubstring(string s)
    {
        var set = new HashSet<char>();
        int left = 0, maxLen = 0;

        for (int right = 0; right < s.Length; right++)
        {
            while (set.Contains(s[right]))
            {
                set.Remove(s[left++]);
            }

            set.Add(s[right]);
            maxLen = Math.Max(maxLen, right - left + 1);
        }

        return maxLen;
    }

    static void Main(string[] args)
    {
        string input = "abcabcbb";
        int result = LengthOfLongestSubstring(input);
        Console.WriteLine("Length of Longest Substring Without Repeating Characters: " + result);
    }
}
