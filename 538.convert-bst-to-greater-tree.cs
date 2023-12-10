/*
 * @lc app=leetcode.cn id=538 lang=csharp
 * @lcpr version=30111
 *
 * [538] 把二叉搜索树转换为累加树
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
    int pre = 0;
    public TreeNode ConvertBST(TreeNode root)
    {
        if (root == null) return null;
        ConvertBST(root.right);
        root.val += pre;
        pre = root.val;
        ConvertBST(root.left);
        return root;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [4,1,6,0,2,5,7,null,null,null,3,null,null,null,8]\n
// @lcpr case=end

// @lcpr case=start
// [0,null,1]\n
// @lcpr case=end

// @lcpr case=start
// [1,0,2]\n
// @lcpr case=end

// @lcpr case=start
// [3,2,4,1]\n
// @lcpr case=end

 */

