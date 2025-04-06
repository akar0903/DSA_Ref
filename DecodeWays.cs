using System;

class DecodeWays
{
    // Function to compute number of ways to decode the string
    public int NumDecodings(string s)
    {
        if (string.IsNullOrEmpty(s) || s[0] == '0')
            return 0;

        int n = s.Length;
        int[] dp = new int[n + 1];
        dp[0] = 1;
        dp[1] = 1;

        for (int i = 2; i <= n; i++)
        {
            int oneDigit = int.Parse(s.Substring(i - 1, 1));
            int twoDigit = int.Parse(s.Substring(i - 2, 2));

            if (oneDigit >= 1 && oneDigit <= 9)
                dp[i] += dp[i - 1];

            if (twoDigit >= 10 && twoDigit <= 26)
                dp[i] += dp[i - 2];
        }

        return dp[n];
    }

    // Main method to test the function
    static void Main(string[] args)
    {
        DecodeWays decoder = new DecodeWays();

        Console.WriteLine("Enter a numeric string to decode (e.g. 226):");
        string input = Console.ReadLine();

        int result = decoder.NumDecodings(input);

        Console.WriteLine($"Number of ways to decode \"{input}\": {result}");
    }
}
