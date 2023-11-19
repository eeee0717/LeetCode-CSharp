/*
 * @lc app=leetcode.cn id=110 lang=csharp
 * @lcpr version=30109
 *
 * [110] 平衡二叉树
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
    public bool IsBalanced(TreeNode root)
    {
        return GetHeight(root) == -1 ? false : true;
    }
    public int GetHeight(TreeNode root)
    {
        if (root == null) return 0;
        int left = GetHeight(root.left);
        if (left == -1) return -1;
        int right = GetHeight(root.right);
        if (right == -1) return -1;
        int res;
        if (Math.Abs(left - right) > 1)
        {
            res = -1;
        }
        else
        {
            res = 1 + Math.Max(left, right);
        }
        return res;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [3,9,20,null,null,15,7]\n
// @lcpr case=end

// @lcpr case=start
// [1,2,2,3,3,null,null,4,4]\n
// @lcpr case=end

// @lcpr case=start
// []\n
// @lcpr case=end

 */

