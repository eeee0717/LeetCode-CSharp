/*
 * @lc app=leetcode.cn id=144 lang=csharp
 * @lcpr version=30108
 *
 * [144] 二叉树的前序遍历
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
    // public IList<int> PreorderTraversal(TreeNode root)
    // {
    //     var res = new List<int>();
    //     if (root == null) return res;
    //     Traversal(root, res);
    //     return res;

    // }
    // public void Traversal(TreeNode cur, IList<int> res)
    // {
    //     if (cur == null) return;
    //     res.Add(cur.val);
    //     Traversal(cur.left, res);
    //     Traversal(cur.right, res);
    // }

    // 迭代
    // public IList<int> PreorderTraversal(TreeNode root)
    // {
    //     var st = new Stack<TreeNode>();
    //     var res = new List<int>();
    //     if (root == null) return res;
    //     st.Push(root);
    //     while (st.Count != 0)
    //     {
    //         var node = st.Pop();
    //         res.Add(node.val);
    //         if (node.right != null)
    //             st.Push(node.right);
    //         if (node.left != null)
    //             st.Push(node.left);
    //     }
    //     return res;
    // }
    public IList<int> PreorderTraversal(TreeNode root)
    {
        var res = new List<int>();
        var st = new Stack<TreeNode>();
        if (root == null) return res;
        st.Push(root);
        while (st.Count != 0)
        {
            var node = st.Peek();
            if (node == null)
            {
                st.Pop();
                node = st.Peek();
                st.Pop();
                res.Add(node.val);
            }
            else
            {
                st.Pop();
                if (node.right != null) st.Push(node.right);
                if (node.left != null) st.Push(node.left);
                st.Push(node);
                st.Push(null);
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

// @lcpr case=start
// [1,2]\n
// @lcpr case=end

// @lcpr case=start
// [1,null,2]\n
// @lcpr case=end

 */

