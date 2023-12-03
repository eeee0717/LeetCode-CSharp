/*
 * @lc app=leetcode.cn id=501 lang=csharp
 * @lcpr version=30111
 *
 * [501] 二叉搜索树中的众数
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
    public List<int> res = new List<int>();
    public int count = 0;
    public int maxCount = 0;
    public TreeNode pre = null;
    public int[] FindMode(TreeNode root)
    {
        SearchBST(root);
        return res.ToArray();
    }
    public void SearchBST(TreeNode root)
    {
        if (root == null) return;
        SearchBST(root.left);
        if (pre == null)
            count = 1;
        else if (pre.val == root.val)
            count++;
        else
            count = 1;

        pre = root;
        if (count == maxCount)
        {
            res.Add(root.val);
        }
        else if (count > maxCount)
        {
            res.Clear();
            res.Add(root.val);
            maxCount = count;
        }
        SearchBST(root.right);
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,null,2,2]\n
// @lcpr case=end

// @lcpr case=start
// [0]\n
// @lcpr case=end

 */

