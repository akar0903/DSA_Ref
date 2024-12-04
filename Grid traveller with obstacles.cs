// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public int UniquePath(int[][] grid){
        int m = grid.Length;
        int n = grid[0].Length;
        if(grid[0][0] == 1 || grid[m-1][n-1] == 1){
            return 0;
        }
        int[,] dp = new int[m,n];
        for(int i=0;i<m;i++){
            if(dp[i,0] == 1){
                break;
            }
            dp[i,0] = 1;
        }
        for(int i=0;i<n;i++){
            if(dp[0,i] == 1){
                break;
            }
            dp[0,i] = 1;
        }
        for(int i=1;i<m;i++){
            for(int j=1;j<n;j++){
                if(grid[i][j] == 1){
                    dp[i,j]=0;
                }
                else{
                    dp[i,j] = dp[i-1,j]+dp[i,j-1];
                }
            }
        }
        return dp[m-1,n-1];
    }
    public static void Main(string[] args)
    {
        HelloWorld solver = new HelloWorld();
        int[][] grid1 = new int[][] {
            new int[] { 0, 0, 0 },
            new int[] { 0, 1, 0 },
            new int[] { 0, 0, 0 }
        };
        Console.WriteLine(solver.UniquePath(grid1));
    }
}
