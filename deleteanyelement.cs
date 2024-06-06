using System;
class HelloWorld {
  static void Main() {
    int[] intarr = new int[9];
    int length=0;
    for(int i=0;i<6;i++){
        intarr[length]=i;
        length++;
    }
    for(int i=2;i<length;i++){ //can be 2,3 i=2 is the index value which you are deleting
        intarr[i-1]=intarr[i];
    }
    length--;
    for(int i=0;i<length;i++){
        Console.WriteLine(intarr[i]);
    }
  }
}
