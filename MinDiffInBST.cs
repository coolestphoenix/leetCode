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
    public int MinDiffInBST(TreeNode root) {
        int minValue = Int32.MaxValue;
        int previousValue = -1;
        GetMinDiff(root, ref previousValue, ref minValue);
        return minValue;
    }
    private void GetMinDiff(TreeNode node, ref int previousValue, ref int minValue){
        if(node == null){
            return;
        }
        
        GetMinDiff(node.left, ref previousValue, ref minValue);
        
         if (previousValue >= 0 && node.val - previousValue < minValue) {
             minValue = node.val - previousValue;
         }
        previousValue = node.val;
        GetMinDiff(node.right, ref previousValue, ref minValue);
    }
}