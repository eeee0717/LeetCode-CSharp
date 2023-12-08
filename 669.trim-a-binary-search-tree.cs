/*
 * @lc app=leetcode.cn id=669 lang=csharp
 * @lcpr version=30111
 *
 * [669] 修剪二叉搜索树
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
    public TreeNode TrimBST(TreeNode root, int low, int high)
    {
        if (root == null) return null;
        if (root.val < low)
            return TrimBST(root.right, low, high);

        if (root.val > high)
            return TrimBST(root.left, low, high);

        root.left = TrimBST(root.left, low, high);
        root.right = TrimBST(root.right, low, high);
        return root;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,0,2]\n1\n2\n
// @lcpr case=end

// @lcpr case=start
// [3,0,4,null,2,null,null,1]\n1\n3\n
// @lcpr case=end

 */

