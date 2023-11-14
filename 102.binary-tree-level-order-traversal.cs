/*
 * @lc app=leetcode.cn id=102 lang=csharp
 * @lcpr version=30109
 *
 * [102] 二叉树的层序遍历
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
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        var res = new List<IList<int>>();
        var que = new Queue<TreeNode>();
        if (root == null) return res;
        que.Enqueue(root);
        while (que.Count != 0)
        {
            var size = que.Count;
            var vec = new List<int>();
            for (int i = 0; i < size; i++)
            {
                var cur = que.Dequeue();
                vec.Add(cur.val);
                if (cur.left != null) que.Enqueue(cur.left);
                if (cur.right != null) que.Enqueue(cur.right);
            }
            res.Add(vec);


        }
        return res;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [3,9,20,null,null,15,7]\n
// @lcpr case=end

// @lcpr case=start
// [1]\n
// @lcpr case=end

// @lcpr case=start
// []\n
// @lcpr case=end

 */

