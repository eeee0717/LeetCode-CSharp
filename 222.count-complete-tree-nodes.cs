/*
 * @lc app=leetcode.cn id=222 lang=csharp
 * @lcpr version=30109
 *
 * [222] 完全二叉树的节点个数
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
    public int CountNodes(TreeNode root)
    {
        if (root == null) return 0;
        var left = root.left;
        var right = root.right;
        int leftDepth = 0, rightDepth = 0;
        while (left != null)
        {
            left = left.left;
            leftDepth++;
        }
        while (right != null)
        {
            right = right.right;
            rightDepth++;
        }
        if (leftDepth == rightDepth)
            return (int)Math.Pow(2, leftDepth+1) - 1;
        return CountNodes(root.left) + CountNodes(root.right) + 1;

    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,2,3,4,5,6]\n
// @lcpr case=end

// @lcpr case=start
// []\n
// @lcpr case=end

// @lcpr case=start
// [1]\n
// @lcpr case=end

 */

