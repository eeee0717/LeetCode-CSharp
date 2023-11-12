/*
 * @lc app=leetcode.cn id=94 lang=csharp
 * @lcpr version=30108
 *
 * [94] 二叉树的中序遍历
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
    // 递归
    // public IList<int> InorderTraversal(TreeNode root)
    // {
    //     var res = new List<int>();
    //     if (root == null) return res;
    //     Traversal(root, res);
    //     return res;
    // }

    // public void Traversal(TreeNode cur, IList<int> res)
    // {
    //     if (cur == null) return;
    //     Traversal(cur.left, res);
    //     res.Add(cur.val);
    //     Traversal(cur.right, res);
    // }
    // 迭代
    public IList<int> InorderTraversal(TreeNode root)
    {
        var st = new Stack<TreeNode>();
        var res = new List<int>();
        var cur = root;

        while (st.Count != 0 || cur != null)
        {
            if (cur != null)
            {
                st.Push(cur);
                cur = cur.left;
            }
            else
            {
                cur = st.Pop();
                res.Add(cur.val);
                cur = cur.right;
            }

        }
        return res;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,null,2,3]\n
// @lcpr case=end

// @lcpr case=start
// []\n
// @lcpr case=end

// @lcpr case=start
// [1]\n
// @lcpr case=end

 */

