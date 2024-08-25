public class Solution {
    public int[] NumberGame(int[] nums) {
        int length = nums.Length;
        Array.Sort(nums);
        for(int i=0;i<length;i+=2){
            int temp = nums[i];
            nums[i] = nums[i+1];
            nums[i+1] = temp;
        }
        return nums;
        
    }
}
