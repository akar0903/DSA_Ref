using System;

class HelloWorld {
    public int Value(char r) {
        switch (r) {
            case 'I': return 1;
            case 'V': return 5;
            case 'X': return 10;
            case 'L': return 50;
            case 'C': return 100;
            case 'D': return 500;
            case 'M': return 1000;
            default: return -1;
        }
    }

    public int RomanToInt(string str) {
        int total = 0;
        for (int i = 0; i < str.Length; i++) {
            int current = Value(str[i]);
            int next = (i + 1 < str.Length) ? Value(str[i + 1]) : 0;

            if (current >= next) {
                total += current;
            } else {
                total += next - current;
                i++; // Skip the next character
            }
        }
        return total;
    }

    static void Main() {
        HelloWorld obj = new HelloWorld();
        string str = "MCMIV";
        Console.WriteLine("Integer form of Roman Numeral is " + obj.RomanToInt(str));
    }
}
