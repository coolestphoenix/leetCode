public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var dict = new Dictionary<char, int>();
        int ans = 0;
        for(int j=0, i=0; j < s.Length; j++)
        {
            if(!dict.ContainsKey(s[j])){
                dict.Add(s[j], j + 1);
            }
            else {
                i = Math.Max(dict[s[j]], i);
                dict[s[j]] = j + 1;
            }
            
            ans = Math.Max(ans, j - i + 1);
        }
        return ans;
    }
}