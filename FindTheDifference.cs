public class Solution {
    public char FindTheDifference(string s, string t) {
        int[] sa = new int[26];
        int[] ta = new int[26];
        
        for (int i=0;i<s.Length;i++){
            sa[s[i] - 'a'] ++;
        }
        for (int i=0;i<t.Length;i++){
            ta[t[i] - 'a'] ++;
        }
        int asciiOfa = (int)'a';
        for (int c=0;c<26; c++){
            if(sa[c] != ta[c]){
                return (char)(asciiOfa + c);
            }
        }
        return ' ';
    }
}