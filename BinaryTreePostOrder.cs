/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public IList<int> PostorderTraversal(TreeNode root) {
        return PostOrder(root).ToList();
    }
    private static IEnumerable<int> PostOrder(TreeNode node)
    {
        if  (node == null)
            yield break;
        
        foreach (var val in PostOrder(node.left))
            yield return val;
        
        foreach (var val in PostOrder(node.right))
            yield return val;
        
        yield return node.val;
        
    }
}