/*
 * @lc app=leetcode.cn id=337 lang=csharp
 * @lcpr version=30121
 *
 * [337] 打家劫舍 III
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
    public int Rob(TreeNode root)
    {
        int[] res = RobResult(root);
        return Math.Max(res[0], res[1]);
    }
    public int[] RobResult(TreeNode root)
    {
        if (root == null) return new int[2];
        int[] res = new int[2];

        int[] left = RobResult(root.left);
        int[] right = RobResult(root.right);

        res[0] = Math.Max(left[0], left[1]) + Math.Max(right[0], right[1]);
        res[1] = left[0] + right[0] + root.val;

        return res;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [3,2,3,null,3,null,1]\n
// @lcpr case=end

// @lcpr case=start
// [3,4,5,1,3,null,1]\n
// @lcpr case=end

 */

