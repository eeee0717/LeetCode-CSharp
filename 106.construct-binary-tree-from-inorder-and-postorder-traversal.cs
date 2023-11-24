/*
 * @lc app=leetcode.cn id=106 lang=csharp
 * @lcpr version=30110
 *
 * [106] 从中序与后序遍历序列构造二叉树
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
    public TreeNode BuildTree(int[] inorder, int[] postorder)
    {
        if (inorder.Length == 0 || postorder.Length == null) return null;
        int rootValue = postorder.Last();
        TreeNode root = new TreeNode(rootValue);
        int delimiterIndex = Array.IndexOf(inorder, rootValue);
        root.left = BuildTree(inorder.Take(delimiterIndex).ToArray(), postorder.Take(delimiterIndex).ToArray());
        root.right = BuildTree(inorder.Skip(delimiterIndex + 1).ToArray(), postorder.Skip(delimiterIndex).Take(inorder.Length - delimiterIndex - 1).ToArray());
        return root;
    }

}
// @lc code=end



/*
// @lcpr case=start
// [9,3,15,20,7]\n[9,15,7,20,3]\n
// @lcpr case=end

// @lcpr case=start
// [-1]\n[-1]\n
// @lcpr case=end

 */

