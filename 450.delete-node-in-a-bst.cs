/*
 * @lc app=leetcode.cn id=450 lang=csharp
 * @lcpr version=30111
 *
 * [450] 删除二叉搜索树中的节点
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
    public TreeNode DeleteNode(TreeNode root, int key)
    {
        if (root == null) return root;
        if (root.val == key)
        {
            if (root.left == null && root.right == null) return null;
            if (root.left == null && root.right != null) return root.right;
            if (root.left != null && root.right == null) return root.left;
            if (root.left != null && root.right != null)
            {
                TreeNode leftNode = root.right;
                while (leftNode.left != null)
                    leftNode = leftNode.left;
                leftNode.left = root.left;
                return root.right;

            }
        }
        if (root.val > key) root.left = DeleteNode(root.left, key);
        if (root.val < key) root.right = DeleteNode(root.right, key);
        return root;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [5,3,6,2,4,null,7]\n3\n
// @lcpr case=end

// @lcpr case=start
// [5,3,6,2,4,null,7]\n0\n
// @lcpr case=end

// @lcpr case=start
// []\n0\n
// @lcpr case=end

 */

