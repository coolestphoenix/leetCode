//Using list runtime was high
public class RecentCounter {
    List<int> pings;
    public RecentCounter() {
        pings = new List<int>();
    }
    
    public int Ping(int t) {
        pings.Add(t);
        pings.RemoveAll(p => p < t - 3000);
        return pings.Count();
    }
}

/**
 * Your RecentCounter object will be instantiated and called as such:
 * RecentCounter obj = new RecentCounter();
 * int param_1 = obj.Ping(t);
 */

//Using queue runtime was improved
 public class RecentCounter {
    Queue<int> pings;
    public RecentCounter() {
        pings = new Queue<int>();
    }
    
    public int Ping(int t) {
        pings.Enqueue(t);
        while(pings.Peek() < t - 3000){
            pings.Dequeue();
        }
        return pings.Count();
    }
}

/**
 * Your RecentCounter object will be instantiated and called as such:
 * RecentCounter obj = new RecentCounter();
 * int param_1 = obj.Ping(t);
 */