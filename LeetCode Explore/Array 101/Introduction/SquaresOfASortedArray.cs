public class Solution {
    public int[] SortedSquares(int[] nums) {
        if(nums[0] >= 0)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                nums[i] = nums[i] * nums[i];
            }
            
            return nums;
        }
        
        int[] result = new int[nums.Length];
        int right = 0;
        int left = nums.Length - 1;
        
        for(int i = nums.Length - 1; i > -1; i--)
        {
            if(nums[right] * nums[right] >= nums[left] * nums[left])
            {
                result[i] = nums[right] * nums[right];
                right++;
                continue;
            }
            
            result[i] = nums[left] * nums[left];
            left--;
        }
        
        return result;
    }
}