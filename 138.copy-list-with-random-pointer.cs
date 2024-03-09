/*
 * @lc app=leetcode.cn id=138 lang=csharp
 * @lcpr version=30118
 *
 * [138] 随机链表的复制
 */


// @lcpr-template-start

// @lcpr-template-end
// @lc code=start
/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution
{
    IDictionary<Node, Node> copyDictionary = new Dictionary<Node, Node>();


    public Node CopyRandomList(Node head)
    {
        if(head == null) return null;
        if(!copyDictionary.ContainsKey(head))
        {
            var copyHead = new Node(head.val);
            copyDictionary.Add(head, copyHead);
            copyHead.next = CopyRandomList(head.next);
            copyHead.random = CopyRandomList(head.random);
        }
        return copyDictionary[head];
    }
}
// @lc code=end



/*
// @lcpr case=start
// [[7,null],[13,0],[11,4],[10,2],[1,0]]\n
// @lcpr case=end

// @lcpr case=start
// [[1,1],[2,1]]\n
// @lcpr case=end

// @lcpr case=start
// [[3,null],[3,0],[3,null]]\n
// @lcpr case=end

 */

