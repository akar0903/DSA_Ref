using System;
class HelloWorld {
  static void Main() {
    int[] intarr = new int[9];
    int length=0;
    for(int i=0;i<6;i++){
        intarr[length]=i;
        length++;
    }
    for(int i=1;i<length;i++){
        intarr[i-1]=intarr[i];
    }
    length--;
    for(int i=0;i<length;i++){
        Console.WriteLine(intarr[i]);
    }
  }
}
