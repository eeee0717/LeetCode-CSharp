/*
 * @lc app=leetcode.cn id=108 lang=csharp
 * @lcpr version=30111
 *
 * [108] 将有序数组转换为二叉搜索树
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
    public TreeNode SortedArrayToBST(int[] nums)
    {
        return Traversal(nums, 0, nums.Length - 1);
    }
    public TreeNode Traversal(int[] nums, int left, int right)
    {
        if (left > right) return null;
        int mid = left + (right - left) / 2;
        TreeNode node = new TreeNode(nums[mid]);
        node.left = Traversal(nums, left, mid - 1);
        node.right = Traversal(nums, mid + 1, right);
        return node;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [-10,-3,0,5,9]\n
// @lcpr case=end

// @lcpr case=start
// [1,3]\n
// @lcpr case=end

 */

