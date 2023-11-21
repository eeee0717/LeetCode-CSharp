/*
 * @lc app=leetcode.cn id=404 lang=csharp
 * @lcpr version=30110
 *
 * [404] 左叶子之和
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
    public int SumOfLeftLeaves(TreeNode root)
    {
        if (root == null) return 0;

        int leftValue = SumOfLeftLeaves(root.left);
        if (root.left != null && root.left.left == null && root.left.right == null)
        {
            leftValue += root.left.val;
        }
        int rightValue = SumOfLeftLeaves(root.right);
        return leftValue + rightValue;

    }
}
// @lc code=end



/*
// @lcpr case=start
// [3,9,20,null,null,15,7]\n
// @lcpr case=end

// @lcpr case=start
// [1]\n
// @lcpr case=end

 */

