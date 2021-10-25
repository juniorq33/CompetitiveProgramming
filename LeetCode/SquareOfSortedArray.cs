public class Solution {
    public int[] SortedSquares(int[] nums) {
        
         int[] result = new int[nums.Length];

            int i = 0;
            int j = nums.Length - 1;
            int k = nums.Length - 1;

            while (k >= 0)
            {
                if(Math.Abs(nums[i]) < Math.Abs(nums[j]))
                {
                    result[k] = nums[j] * nums[j];
                    j--;
                }
                else
                {
                    result[k] = nums[i] * nums[i];
                    i++;
                }

                k--;
            }

            return result; 
    }
}