public class Solution {
    public int DominantIndex(int[] nums) {
        int max = int.MinValue;
        int secondmax = int.MinValue;
        int n = nums.Length;
        int maxIndex = -1;
        for(int i =0;i<n;i++){
            if(nums[i] > max){
                secondmax = max;
                max = nums[i];
                maxIndex = i;
            }
            else if(nums[i] > secondmax){
                secondmax = nums[i];
            }
        }
        if(max >= 2 * secondmax){
            return maxIndex;
        }
        else{
            return -1;
        }
    }
}
