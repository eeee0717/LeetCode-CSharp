/*
 * @lc app=leetcode.cn id=111 lang=csharp
 * @lcpr version=30109
 *
 * [111] 二叉树的最小深度
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
    // public int MinDepth(TreeNode root)
    // {
    //     if (root == null) return 0;
    //     int left = MinDepth(root.left);
    //     int right = MinDepth(root.right);
    //     if (root.left == null && root.right != null)
    //         return 1+right;
    //     else if(root.left!=null && root.right == null)
    //         return 1+left;

    //     int res = 1 + Math.Min(left, right);
    //     return res;
    // }
    public int MinDepth(TreeNode root)
    {
        if (root == null) return 0;
        int depth = 0;
        var que = new Queue<TreeNode>();
        que.Enqueue(root);
        while (que.Count > 0)
        {
            int size = que.Count;
            depth++;
            for (int i = 0; i < size; i++)
            {
                var node = que.Dequeue();
                if (node.left != null)
                    que.Enqueue(node.left);
                if (node.right != null)
                    que.Enqueue(node.right);
                if (node.left == null && node.right == null)
                    return depth;
            }
        }
        return depth;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [3,9,20,null,null,15,7]\n
// @lcpr case=end

// @lcpr case=start
// [2,null,3,null,4,null,5,null,6]\n
// @lcpr case=end

 */

