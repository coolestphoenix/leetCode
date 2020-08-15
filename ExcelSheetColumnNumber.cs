public class Solution {
    public int TitleToNumber(string s) {
        int result = 0;
        foreach (char c in s.ToCharArray()) {
            result = result * 26 + (c - 'A') + 1;
        }
        return result;
    }
}