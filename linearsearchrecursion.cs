using System;

class HelloWorld {
    public static void Main(String[] args) {
        int[] arr = {3, 5, 4, 6};
        int target = 6;
        Console.WriteLine(ContainsTarget(arr, target, 0));
        Console.WriteLine(findindex(arr,target,0));
    }

    static bool ContainsTarget(int[] arr, int target, int index) {
        if (index >= arr.Length) {
            return false;
        }
        if (arr[index] == target) {
            return true;
        }
        return ContainsTarget(arr, target, index + 1);
    }
    static int findindex(int[] arr,int target,int index){
        if(index>=arr.Length){
            return -1;
        }
        if(arr[index]==target){
            return index;
        }
        return findindex(arr,target,index+1);
    }
}
