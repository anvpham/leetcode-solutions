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
        nums.CopyTo(result, 0);
        int left = 0;
        int right = nums.Length - 1;

        for(int i = nums.Length - 1; i >= 0; i--)
        {
            if(Math.Abs(nums[right]) >= Math.Abs(nums[left]))
            {
                result[i] = nums[right] * nums[right];
                right--;
                continue;
            }

            result[i] = nums[left] * nums[left];
            left++;
        }

        return result;
    }
}