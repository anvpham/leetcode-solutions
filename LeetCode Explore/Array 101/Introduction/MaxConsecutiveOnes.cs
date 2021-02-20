public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int maxCount = 0;
        int currentCount = 0;
        
        for(int i = 0; i < nums.Length; i++) {
            if(nums[i] == 1)
            {
                currentCount++;
            }
            else
            {
                if(currentCount > maxCount)
                {
                    maxCount = currentCount;
                }
                
                currentCount = 0;
            }
        }
        
        return currentCount > maxCount ? currentCount : maxCount;
    }
}