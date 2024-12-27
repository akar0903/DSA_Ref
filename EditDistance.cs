using System;

public class HelloWorld
{
    static int EditDistRec(string s1,string s2,int m,int n){
        if(m == 0) return n;
        if(n == 0) return m;
        if(s1[m-1]==s2[n-1]){
            return EditDistRec(s1,s2,m-1,n-1);
        }
        return 1 + Math.Min(Math.Min(EditDistRec(s1,s2,m-1,n),
        EditDistRec(s1,s2,m,n-1)),EditDistRec(s1,s2,m-1,n-1)
            );
    }
    public static void Main(string[] args)
    {
       string s1 = "GEEXSFRDEEKKS";
       string s2 = "GEEKSFORGEEKS";
       int m = s1.Length;
       int n = s2.Length;
       Console.WriteLine("Minimum operations: " + EditDistRec(s1, s2,m,n));
    }
}
