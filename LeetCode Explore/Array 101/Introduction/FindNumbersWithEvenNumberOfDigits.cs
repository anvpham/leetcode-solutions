public class Solution {
    public int FindNumbers(int[] nums) {
        int result = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            var digits = nums[i].ToString().Length;
            if(digits % 2 == 0)
            {
                result++;
            }
        }

        return result;
    }
}