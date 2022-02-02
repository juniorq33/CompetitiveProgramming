public class Solution {
    public bool IsAnagram(string s, string t) {
        
            if (s.Length == 0 || t.Length == 0 || (s.Length != t.Length))
                return false;

            int[] hash1 = new int[26];
            int[] hash2 = new int[26];

            for (int i = 0; i < s.Length; i++)
            {
                hash1[s[i] - 'a']++;
                hash2[t[i] - 'a']++;
            }

            int j = 0;
            while (j < 26)
            {
                if(hash1[j] != hash2[j])
                {
                    return false;
                }

                j++;
            }

            return true;
        
    }
}