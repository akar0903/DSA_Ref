using System;

class HelloWorld {
    public static void Main(String[] args) {
        skip("", "bcanmaln");
        skipapple("", "applertyui");
    }
    
    static void skip(string p, string up) {
        if (string.IsNullOrEmpty(up)) {
            Console.WriteLine(p);
            return;
        }
        
        char ch = up[0];
        if (ch == 'a') {
            skip(p, up.Substring(1));
        } else {
            skip(p + ch, up.Substring(1));
        }
    }
    
    static void skipapple(string pp, string upp) {
        if (string.IsNullOrEmpty(upp)) {
            Console.WriteLine(pp);
            return;
        }
        
        if (upp.StartsWith("apple")) {
            skipapple(pp, upp.Substring(5));
        } else {
            char chh = upp[0];
            skipapple(pp + chh, upp.Substring(1));
        }
    }
}
