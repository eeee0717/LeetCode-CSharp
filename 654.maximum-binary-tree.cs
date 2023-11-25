/*
 * @lc app=leetcode.cn id=654 lang=csharp
 * @lcpr version=30110
 *
 * [654] 最大二叉树
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
    public TreeNode ConstructMaximumBinaryTree(int[] nums)
    {
        if (nums.Length == 0) return null;
        int rootValue = nums.Max();
        TreeNode root = new TreeNode(rootValue);
        int rootIndex = Array.IndexOf(nums, rootValue);

        root.left = ConstructMaximumBinaryTree(nums.Take(rootIndex).ToArray());
        root.right = ConstructMaximumBinaryTree(nums.Skip(rootIndex + 1).ToArray());
        return root;

    }
}
// @lc code=end



/*
// @lcpr case=start
// [3,2,1,6,0,5]\n
// @lcpr case=end

// @lcpr case=start
// [3,2,1]\n
// @lcpr case=end

 */

