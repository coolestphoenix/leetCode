public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        if(s.Length <= 0 ) return true;
        
        char[] a = new char[26]; 
        char[] b = new char[26];
        Array.Clear(a, 0, a.Length);
        Array.Clear(a, 0, a.Length);
        
        for(int i = 0; i < s.Length; i++)
        {
            a[s[i] - 'a']++;
            b[t[i] - 'a']++;
        }
        
        for(int i = 0; i < 26; i++)
        {
            if(a[i] != b[i]) return false;
        }
        
        return true;
    }
    public bool IsAnagram(string s, string t) {
        if (s == t){
            return true;
        }
        if(string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t))
        {
            return false;
        }
        var charS = s.ToCharArray();
        Array.Sort(charS);
        var sortedStringS = new string(charS);
        
        var charT = t.ToCharArray();
        Array.Sort(charT);
        var sortedStringT = new string(charT);
        
        if(sortedStringS == sortedStringT){
            return true;
        }
        else 
        {
            return false;
        }
    }
}