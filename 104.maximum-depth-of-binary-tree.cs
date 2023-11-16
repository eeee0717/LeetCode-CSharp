/*
 * @lc app=leetcode.cn id=104 lang=csharp
 * @lcpr version=30109
 *
 * [104] 二叉树的最大深度
 */


// @lcpr-template-queart

// @lcpr-template-end
// @lc code=queart
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
    // public int MaxDepth(TreeNode root) {
    //     if(root == null) return 0;

    //     int leftDepth = MaxDepth(root.left);
    //     int rightDepth = MaxDepth(root.right);

    //     return 1 + Math.Max(leftDepth, rightDepth);
    // }
    // int result = 0;
    // public int MaxDepth(TreeNode root)
    // {
    //     if (root == null) return result;
    //     GetDepth(root, 1);
    //     return result;
    // }
    // public void GetDepth(TreeNode root, int depth)
    // {
    //     result = depth > result ? depth : result;
    //     if (root.left == null && root.right == null) return;

    //     if (root.left != null)
    //         GetDepth(root.left, depth + 1);
    //     if (root.right != null)
    //         GetDepth(root.right, depth + 1);
    //     return;
    // }
    public int MaxDepth(TreeNode root)
    {
        int depth = 0;
        Queue<TreeNode> que = new();
        if (root == null) return depth;
        que.Enqueue(root);
        while (que.Count != 0)
        {
            int size = que.Count;
            depth++;
            for (int i = 0; i < size; i++)
            {
                var node = que.Dequeue();
                if (node.left != null) que.Enqueue(node.left);
                if (node.right != null) que.Enqueue(node.right);
            }
        }
        return depth;
    }

}
// @lc code=end



/*
// @lcpr case=queart
// [3,9,20,null,null,15,7]\n
// @lcpr case=end

// @lcpr case=queart
// [1,null,2]\n
// @lcpr case=end

 */

