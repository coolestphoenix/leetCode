public class TrieNode{
    public char c;
    public Dictionary<char, TrieNode> children = new Dictionary<char, TrieNode>();
    public bool isLeaf;
 
    public TrieNode() {}
 
    public TrieNode(char c){
        this.c = c;
    }
}
public class WordDictionary {
    
    private TrieNode root;
    /** Initialize your data structure here. */
    public WordDictionary() {
        root = new TrieNode();
    }
    
    /** Adds a word into the data structure. */
    public void AddWord(string word) {
        var children = root.children;
 
        for(int i=0; i<word.Length; i++){
            char c = word[i];
 
            TrieNode t = null;
            if(children.ContainsKey(c)){
                t = children[c];
            }else{
                t = new TrieNode(c);
                children.Add(c,t);
            }
 
            children = t.children;
 
            if(i == word.Length-1){
                t.isLeaf = true;
            }
        }
    }
    
    /** Returns if the word is in the data structure. A word could contain the dot character '.' to represent any one letter. */
    public bool Search(string word) {
       return dfsSearch(root.children, word, 0);
        
    }
    public bool dfsSearch(Dictionary<char, TrieNode> children, string word, int start) {
        if(start == word.Length){
            if(children.Count==0) 
                return true; 
            else
                return false;
        }
 
        char c = word[start];    
 
        if(children.ContainsKey(c)){
            if(start == word.Length-1 && children[c].isLeaf){
                return true;
            }
 
            return dfsSearch(children[c].children, word, start+1);
        }else if(c == '.'){
            var result = false;
            foreach(var child in children){
                if(start == word.Length-1 && child.Value.isLeaf){
                    return true;
                } 
 
                //if any path is true, set result to be true; 
                if(dfsSearch(child.Value.children, word, start+1)){
                    result = true;
                }
            }
 
            return result;
        }else{
            return false;
        }
    }
}

/**
 * Your WordDictionary object will be instantiated and called as such:
 * WordDictionary obj = new WordDictionary();
 * obj.AddWord(word);
 * bool param_2 = obj.Search(word);
 */