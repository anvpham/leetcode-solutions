public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int pointer = 0;
        
        for(int i = 0; i < nums1.Length; i++)
        {
            if(pointer == n) break;
            if(nums1[i] >= nums2[pointer])
            {
                Shift(nums1, i);
                nums1[i] = nums2[pointer];
                pointer++;
            }
        }
        
        for(int i = nums1.Length - n + pointer; i < nums1.Length; i++)
        {
            nums1[i] = nums2[pointer];
            pointer++;
        }
    }
    
    private void Shift(int[] arr, int position)
    {
        for(int i = arr.Length - 1; i > position; i--)
        {
            arr[i] = arr[i - 1];
        }
    }
}