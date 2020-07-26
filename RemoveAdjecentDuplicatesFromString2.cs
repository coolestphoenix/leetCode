
public class Solution {
    //Acceptedsolution
    class KV{
        public char character;
        public short count;
        public KV(char c, short s){
            character = c;
            count = s;
        }
    }
    public string RemoveDuplicates(string s, int k) {
        var lstDic = new List<KV>();
        foreach(var ch in s){
            if (lstDic.Count > 0 && lstDic[lstDic.Count - 1].character == ch) {
                var lastItem = lstDic[lstDic.Count - 1];
                lstDic[lstDic.Count - 1].count++;
                if (lstDic[lstDic.Count - 1].count == k) {
                    lstDic.Remove(lstDic[lstDic.Count - 1]);
                }
            }
            else {
                lstDic.Add(new KV(ch, 1));
            }
        }
        var sb = new StringBuilder();
        foreach (var item in lstDic){
            for (int i = 0; i < item.count; i++){
                sb.Append(item.character);
            }
        }
        return sb.ToString();
    }

    //Passed 17 of 18 test cases, on the last test case time limit exceeded
    public string RemoveDuplicates(string s, int k) {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i< s.Length; i++){
            sb.Append(s[i]);
            if (sb.Length >= k) {
                if(subStringMatch(sb.ToString(), k)){
                    sb.Remove(sb.Length -1 - k + 1, k);
                }
            }
        }
        return sb.ToString();
    }
    private bool subStringMatch(string s, int k){
        var matched = true;
        char ch = '0';
        for (int f = 0; f < k; f++){
            if(ch == '0')
            { ch = s[s.Length -1 - f];}
            else{
                matched = matched && ch == s[s.Length -1 -f];
            }
        }
        return matched;
    }
}