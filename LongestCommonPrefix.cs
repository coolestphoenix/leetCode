public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        var commonPrefix = "";
        if(strs == null || strs.Length == 0)
         return commonPrefix;
        
        if(strs.Length == 1){
            return strs[0];
        }
        
        var firstString = strs[0];
        var i = 0;
        while(i <= firstString.Length-1){
            var commonChar = true;
            for (int j = 1;j<strs.Length;j++){
                if(i > strs[j].Length - 1 || firstString[i] != strs[j][i]){
                    commonChar = false;
                }
            }
            if (commonChar){
                commonPrefix += firstString[i];
            }
            else {
                break;
            }
            i++;
        }
        
        
        return commonPrefix;
    }
}