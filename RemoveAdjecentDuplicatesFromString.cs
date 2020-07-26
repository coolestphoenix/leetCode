public class Solution {
    public string RemoveDuplicates(string S) {
        var sb = new StringBuilder();
        foreach (var ch in S){
            if (sb.Length != 0 && sb[sb.Length - 1] == ch){
                sb.Remove(sb.Length - 1, 1);
            }
            else {
                sb.Append(ch);
            }
        }
        return sb.ToString();
    }
}