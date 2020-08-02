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
    public TreeNode SortedArrayToBST(int[] nums) {
        if (nums.Length == 0){
            return null;
        }
        
        return ConvertSortedArrayToBST(nums, 0, nums.Length - 1);
    }
    private TreeNode ConvertSortedArrayToBST(int[] nums, int start, int end){
        if (start > end) {            
            return null;
        }
        int mid = (start + end)/2;
        TreeNode node = new TreeNode(nums[mid]);
        node.left = ConvertSortedArrayToBST(nums, start, mid - 1);
        node.right = ConvertSortedArrayToBST(nums, mid + 1, end);
        return node;
    }
}