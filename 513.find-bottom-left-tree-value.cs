/*
 * @lc app=leetcode.cn id=513 lang=csharp
 * @lcpr version=30110
 *
 * [513] 找树左下角的值
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
    int maxDepth = -1;
    int res = 0;
    public int FindBottomLeftValue(TreeNode root)
    {
        Traversal(root, 0);
        return res;
    }
    public void Traversal(TreeNode root, int depth)
    {
        if (root.left == null && root.right == null)
        {
            if (depth > maxDepth)
            {
                maxDepth = depth;
                res = root.val;
            }
            return;
        }
        if (root.left != null)
        {
            Traversal(root.left, depth + 1);
        }
        if (root.right != null)
        {
            Traversal(root.right, depth + 1);
        }
        return;
    }

}
// @lc code=end



/*
// @lcpr case=start
// [2,1,3]\n
// @lcpr case=end

// @lcpr case=start
// [1,2,3,4,null,5,6,null,null,7]\n
// @lcpr case=end

 */

