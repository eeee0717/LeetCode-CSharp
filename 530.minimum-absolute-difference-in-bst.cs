/*
 * @lc app=leetcode.cn id=530 lang=csharp
 * @lcpr version=30111
 *
 * [530] 二叉搜索树的最小绝对差
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
    public int GetMinimumDifference(TreeNode root)
    {
        Traversal(root);
        return res.SelectMany((x, i) => res.Skip(i + 1).Select(y => Math.Abs(x - y))).Min();

    }
    public void Traversal(TreeNode root)
    {
        if (root == null) return;
        Traversal(root.left);
        res.Add(root.val);
        Traversal(root.right);
    }
}
// @lc code=end



/*
// @lcpr case=start
// [4,2,6,1,3]\n
// @lcpr case=end

// @lcpr case=start
// @lcpr-div-debug-arg-start
// funName= GetMinimumDifference
// paramTypes= ["TreeNode"]

// [1,0,48,null,null,12,49]\n
// @lcpr case=end
// @lcpr-div-debug-arg-end

 */

 // @lcpr-div-debug-arg-start
// funName= GetMinimumDifference
// paramTypes= ["TreeNode"]
// @lcpr-div-debug-arg-end


