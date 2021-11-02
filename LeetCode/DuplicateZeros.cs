public class Solution {
    public void DuplicateZeros(int[] arr) {
        
        int[] newArr = new int[arr.Length];
        Array.Copy(arr, newArr, arr.Length);

        int i = 0;
        int j = 0;
        while(i < newArr.Length && j < newArr.Length)
        {
            if(newArr[i] == 0)
            {
                arr[j] = 0;

                if(j+1 < newArr.Length)
                {
                    arr[j + 1] = 0;
                }
                
                j = j + 2;
            }
            else
            {
                arr[j] = newArr[i];
                j++;
            }

            i++;
        }
    }
}