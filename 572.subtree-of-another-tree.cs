/*
 * @lc app=leetcode.cn id=572 lang=csharp
 * @lcpr version=30201
 *
 * [572] 另一棵树的子树
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
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
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        if(root == null && subRoot == null) return true;
        if(root == null || subRoot== null) return false;
        return IsSameNode(root, subRoot) || IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);
    }
    public bool IsSameNode(TreeNode root, TreeNode subRoot)
    {
        if(root == null && subRoot == null) return true;
        if(root == null || subRoot== null) return false;
        return root.val == subRoot.val && IsSameNode(root.left, subRoot.left) && IsSameNode(root.right, subRoot.right);
    }
}
// @lc code=end



/*
// @lcpr case=start
// [3,4,5,1,2]\n[4,1,2]\n
// @lcpr case=end

// @lcpr case=start
// [3,4,5,1,2,null,null,null,null,0]\n[4,1,2]\n
// @lcpr case=end

 */

