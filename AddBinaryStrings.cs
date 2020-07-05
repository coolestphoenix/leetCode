public class Solution {
    public string AddBinary(string a, string b) {
        if(string.IsNullOrEmpty(a) || string.IsNullOrEmpty(b)){
            return "0";
        }
        var result = "";
        int i = a.Length - 1;int j=b.Length - 1;
        int s = 0;
        while(i >= 0 || j >= 0 || s == 1)
        {
            s += (i >= 0) ? a[i] - '0' : 0;
            s += (j >= 0) ? b[j] - '0' : 0;
            
            result = (s % 2) + result;
            
            s /= 2;
            
            i--;j--;
        }
        return result;
    }
}