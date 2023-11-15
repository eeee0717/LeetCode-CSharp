/*
 * @lc app=leetcode.cn id=101 lang=csharp
 * @lcpr version=30109
 *
 * [101] 对称二叉树
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
    // public bool IsSymmetric(TreeNode root)
    // {
    //     if (root == null) return true;
    //     return Compare(root.left, root.right);
    // }
    // public bool Compare(TreeNode left, TreeNode right)
    // {
    //     if(left == null && right != null) return false;
    //     else if(left != null && right == null ) return false;
    //     else if(left == null && right == null) return true;
    //     else if(left.val != right.val) return false;

    //     var outside = Compare(left.left, right.right);
    //     var inside = Compare(left.right, right.left);

    //     return outside&&inside;
    // }

    public bool IsSymmetric(TreeNode root)
    {
        if (root == null) return true;
        var st = new Stack<TreeNode>();
        st.Push(root.left);
        st.Push(root.right);
        while (st.Count != 0)
        {
            var left = st.Pop();
            var right = st.Pop();
            if (left == null && right == null)
                continue;

            if ((left == null || right == null || (left.val != right.val)))
                return false;

            st.Push(left.left);
            st.Push(right.right);
            st.Push(left.right);
            st.Push(right.left);
        }
        return true;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,2,2,3,4,4,3]\n
// @lcpr case=end

// @lcpr case=start
// [1,2,2,null,3,null,3]\n
// @lcpr case=end

 */

