public class Solution {
    public int NumJewelsInStones(string J, string S) {
        int jewels = 0;
        for (int i=0;i<S.Length;i++){
            if(J.Contains(S[i])){
                jewels++;
            }
        }
        return jewels;
    }
}