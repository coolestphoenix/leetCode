public class Solution {
    public bool BackspaceCompare(string S, string T) {
        return removeBackspaces(S) == removeBackspaces(T);
    }
    public string removeBackspaces(string str){
        Stack<char> s = new Stack<char>();
        for (int i= 0; i<str.Length;i++){
            if(str[i] != '#'){
                s.Push(str[i]);
            }
            else if (s.Count != 0){
                s.Pop();
            }
        }
        return new String(s.ToArray());
    }
}