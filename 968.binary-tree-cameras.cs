/*
 * @lc app=leetcode.cn id=968 lang=csharp
 * @lcpr version=30113
 *
 * [968] 监控二叉树
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
    public int res = 0;
    public int MinCameraCover(TreeNode root)
    {
        if (Traversal(root) == 0) res++;
        return res;
    }
    public int Traversal(TreeNode cur)
    {
        // 0:无覆盖
        // 1:有摄像头
        // 2:有覆盖
        if (cur == null) return 2;
        int left = Traversal(cur.left);
        int right = Traversal(cur.right);
        if (left == 2 && right == 2) return 0;
        else if (left == 0 || right == 0)
        {
            res++;
            return 1;
        }
        else return 2;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [0,0,null,0,0]\n
// @lcpr case=end

// @lcpr case=start
// [0,0,null,0,null,0,null,null,0]\n
// @lcpr case=end

 */

