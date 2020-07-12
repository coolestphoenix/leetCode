public class Solution {
    public string[] UncommonFromSentences(string A, string B) {
        var lst = new List<string>();
        lst.AddRange(A.Split(" "));
        lst.AddRange(B.Split(" "));
        Dictionary<string, int> dict = new Dictionary<string, int>();
        foreach(var word in lst){
            if(!dict.ContainsKey(word)){
                dict.Add(word, 1);
            }
            else{
                dict[word]++;
            }
        }
        
        return dict.Where(d => d.Value == 1).Select(d => d.Key).ToArray();
    }
}