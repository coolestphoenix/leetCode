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
    public IList<IList<int>> VerticalTraversal(TreeNode root) {
        Dictionary<int, IList<int>> map = new Dictionary<int, IList<int>>();
        if (root == null){
            return null;
        }
        MappNodes(root, 0, 0, map);
        List<IList<int>> result = new List<IList<int>>();
        foreach (var kv in map.OrderBy(d => d.Key)){
            IList<int> values = kv.Value.OrderBy(v => v).ToList();
            result.Add(values);
        }
        return result;
    }
    private void MappNodes(TreeNode node, int x, int y, Dictionary<int,IList<int>> mappings)
    {
        if(node == null){
            return;
        }
        if(mappings.ContainsKey(x)){
            mappings[x].Add(node.val);
        }
        else{
            mappings.Add(x, new List<int>{ node.val });
        }
        MappNodes(node.left,x - 1, y - 1, mappings);
        MappNodes(node.right, x+1, y -1, mappings);
    }
    
}