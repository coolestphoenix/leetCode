public class Solution {
    public bool IsPalindrome(string s) {
        s = s.Replace(" ", "");
        s = s.Replace(",", "");
        s = s.Replace(":", "");
        s = s.Replace(".", "");
        s = s.Replace("@", "");
        s = s.Replace("#", "");
        s = s.Replace("_", "");
        s = s.Replace("{", "");
        s = s.Replace("}", "");
        s = s.Replace("[", "");
        s = s.Replace("]", "");
        s = s.Replace("\\", "");
        s = s.Replace("\"", "");
        s = s.Replace("'", "");
        s = s.Replace("-", "");
        s = s.Replace("?", "");
        s = s.Replace(";", "");
        s = s.Replace("!", "");
        s = s.Replace("(", "");        
        s = s.Replace(")", "");
        s = s.Replace("`", "");
        s = s.ToLower();
        if(string.IsNullOrEmpty(s)){
            return true;
        }
        int length = s.Length -1;
        if(length == 0){
            return true;
        }
        for (int k = 0; k <= length / 2; k++) {
            if (s[k] != s[length - k]) return false;
        }
        return true;
    }
}