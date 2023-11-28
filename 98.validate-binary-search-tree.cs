/*
 * @lc app=leetcode.cn id=98 lang=csharp
 * @lcpr version=30111
 *
 * [98] 验证二叉搜索树
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
public class Solution
{
    public long val = Int64.MinValue;
    public bool IsValidBST(TreeNode root)
    {
        if (root == null) return true;
        bool left = IsValidBST(root.left);
        if (root.val > val) val = root.val;
        else return false;
        bool right = IsValidBST(root.right);
        return left && right;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [2,1,3]\n
// @lcpr case=end

// @lcpr case=start
// [5,1,4,null,null,3,6]\n
// @lcpr case=end

 */

