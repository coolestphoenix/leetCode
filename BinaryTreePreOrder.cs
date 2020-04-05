public class Solution {
    public IList<int> PreorderTraversal(TreeNode root) {
        return Travers(root).ToList();
    }
    
    private static IEnumerable<int> Travers(TreeNode node) {
        if (node == null)
            yield break;
        
        yield return node.val;
        
        foreach (var val in Travers(node.left))
            yield return val;
        
        foreach (var val in Travers(node.right))
            yield return val;
    }
}