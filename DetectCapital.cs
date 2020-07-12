public class Solution {
    public bool DetectCapitalUse(string word) {
        if(word == word.ToUpper()){
            return true;
        }
        if(word == word.ToLower()){
            return true;
        }
        if(word[0].ToString() == word[0].ToString().ToUpper() && word.Substring(1, word.Length-1) == word.Substring(1, word.Length-1).ToLower()){
            return true;
        }
        return false;
    }
}