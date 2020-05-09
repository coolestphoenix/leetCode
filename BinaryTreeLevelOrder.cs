/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public IList<IList<int>> LevelOrder(TreeNode root) {
        var result = new List<IList<int>>();
        BreadthFirstSearch(root, result);
        return result;
    }
    public void BreadthFirstSearch(TreeNode root, List<IList<int>> res)
    {
        var curQueue = new Queue<TreeNode>();
        var nextLevel = new Queue<TreeNode>();
        if (root == null)
            return;
        
        curQueue.Enqueue(root);
        while(curQueue.Any()){
            var values = new List<int>();
            nextLevel = new Queue<TreeNode>();
            while(curQueue.Any()){
                var item = curQueue.Dequeue();
                values.Add(item.val);
                
                if(item.left != null)
                    nextLevel.Enqueue(item.left);
                
                if(item.right != null)
                    nextLevel.Enqueue(item.right);
            }
            curQueue = nextLevel;
            res.Add(values);
        }
    }
}