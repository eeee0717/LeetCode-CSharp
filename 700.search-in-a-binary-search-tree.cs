/*
 * @lc app=leetcode.cn id=700 lang=csharp
 * @lcpr version=30111
 *
 * [700] 二叉搜索树中的搜索
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
    // public TreeNode SearchBST(TreeNode root, int val)
    // {
    //     if (root == null || root.val == val) return root;
    //     if (root.val > val) return SearchBST(root.left, val);
    //     if (root.val < val) return SearchBST(root.right, val);
    //     return null;
    // }
    public TreeNode SearchBST(TreeNode root, int val)
    {
        while (root != null)
        {
            if (root.val > val) root = root.left;
            else if (root.val < val) root = root.right;
            else return root;
        }
        return null;

    }
}
// @lc code=end



/*
// @lcpr case=start
// [4,2,7,1,3]\n2\n
// @lcpr case=end

// @lcpr case=start
// [4,2,7,1,3]\n5\n
// @lcpr case=end

 */

