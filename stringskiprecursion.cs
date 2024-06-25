using System;

class HelloWorld {
    public static void Main(String[] args) {
        skip("", "bcanmal");
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
}
