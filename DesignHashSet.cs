public class MyHashSet {
    List<int> lst;
    /** Initialize your data structure here. */
    public MyHashSet() {
        lst = new List<int>();
    }
    
    public void Add(int key) {
        if(!lst.Contains(key)){
            lst.Add(key);
        }
    }
    
    public void Remove(int key) {
        if(lst.Contains(key)){
            lst.Remove(key);
        }
    }
    
    /** Returns true if this set contains the specified element */
    public bool Contains(int key) {
        return lst.Contains(key);
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */