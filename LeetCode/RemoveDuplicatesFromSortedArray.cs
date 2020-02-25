public class Solution {
    public int RemoveDuplicates(int[] nums) {

        if(nums.Length == 0)
        {
            return 0;
        }
        
        int currentnum = 0;
        int tempIndex = 0;
        int prevnum = nums[0];
        
        for(int i = 0; i < nums.Length; i++)
        {
            currentnum = nums[i];

            if(prevnum != currentnum)
            {
                tempIndex++;
                nums[tempIndex] = nums[i];
            }
            
            prevnum = nums[i];
        }
        
        
        return tempIndex + 1;
    }
}