public class Solution {
    public int FindNumbers(int[] nums) {
        
        int result = 0;
        
        for (int i = 0; i < nums.Length; i++)
        {
            int numDigits = 0;
            
             numDigits = DivideTen(nums[i], numDigits);
            
            if(numDigits % 2 == 0)
            {
                result++;
            }
        }
        
        return result;
    }
    
    public int DivideTen(int num, int numDigits)
    {
        if(num == 0)
        {
            return numDigits;
        }
        return DivideTen(num / 10, ++numDigits);
        
    }
}